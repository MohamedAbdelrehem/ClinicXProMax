using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Clinic_Mang_Sys.Models;
using Clinic_Mang_Sys.Lib;
using Kimtoo.BindingProvider;
using Kimtoo.DbContext;
using ServiceStack.OrmLite;


namespace Clinic_Mang_Sys.Pages
{
    public partial class PageAppointments : UserControl
    {
        public bool IsAppointments { get; set; }
        public static PageAppointments instance;
        public PageAppointments()
        {
            if (this.IsInDesignMode())
                return;
            InitializeComponent();

            //allow change in pages request from other forms
            instance = this;

            DateSwitch.Checked = true;
            PatientAppoimentDatePicker.Enabled = true;

            //set time picker to this date
            PatientAppoimentDatePicker.Value = DateTime.Now;

            gridAppointment.OnDelete<Appointment>((a, b) => Db.Get().Delete(a) >= 0);
        }

        private void LoadData()
        {
            TabGrid.Visible = this.IsAppointments;
            //Cursor look
            Cursor.Current = Cursors.WaitCursor;

            //get data for shadowbox dropmenu
            PatientIdDropdown.DataSource = Db.Get().Select<Patients>();

            List<Appointment> data = Db.Get().Select<Appointment>();

            //get data for table

            if (DateSwitch.Checked == true)
            {
                data = data.Where(r => r.Date.Date == PatientAppoimentDatePicker.Value.Date)
                    .ToList();
            }

            if (this.IsAppointments)
            {
                if (TabGrid.CurrentSelection.Trim() == "Active")
                {
                    data = data.Where(r => !r.HasSessions() && !r.Cancelled).ToList();
                }
                else if (TabGrid.CurrentSelection.Trim() == "Cancelled")
                {
                    data = data.Where(r => r.Cancelled).ToList();
                }
            }
            else
            {
                data = data.Where(r => r.HasSessions()).ToList();
            }

            gridAppointment.Bind<Appointment>(data);
            Cursor.Current = Cursors.Default;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            pnlDrawwer.Visible = false;
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PatientIdDropdown.DataSource = Db.Get().Select<Patients>();
            pnlDrawwer.Visible = true;
            bindingProvider1.Bind(new Appointment());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //check validation
            if (validationProvider1.Validate().Length > 0)
                return;

            IDbConnection db = Db.Get();
            bool SaveState = db.Save(bindingProvider1.Get<Appointment>(), references: true);

            //get state of Data was edited or Inserted (new)
            string AddOrEditedMessage;
            if (SaveState)
            {
                AddOrEditedMessage = "Appointment Added";
            }
            else
            {
                AddOrEditedMessage = "Appointment updated";
            }

            LoadData();
            pnlDrawwer.Visible = false;

            //show AddOrEditedMessage
            bunifuSnackbar1.Show(
                this.FindForm(),
                AddOrEditedMessage,
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success
            );
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex == ColEdit.Index)
            {
                pnlDrawwer.Visible = true;
                bindingProvider1.Bind(gridAppointment.GetRecord<Appointment>());
                buttonSave.Visible = CancelCheckBox.Enabled = !gridAppointment
                    .GetRecord<Appointment>()
                    .HasSessions();
            }
            if (e.ColumnIndex == ColDel.Index)
            {
                gridAppointment.DeleteRow<Appointment>();
            }
        }

        private void SearchTextBox_TextChange(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Trim().Length > 0)
            {
                gridAppointment.SearchRows(SearchTextBox.Text);
            }
            else
                LoadData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            LoadData();
        }

        private void GridTabs_OnSelectionChange(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PatientAppoimentDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        //switch to enable or disable filter by date
        private void DateSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (DateSwitch.Checked == true)
            {
                PatientAppoimentDatePicker.Enabled = true;
            }
            else
            {
                PatientAppoimentDatePicker.Enabled = false;
            }
            SearchTextBox.Text = "";
            LoadData();
        }

        private void gridAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check if grid is empty before it try show open
            int rowCount = gridAppointment.RowCount;
            if (rowCount > 0)
            {
                buttonTreatment.Text = gridAppointment.GetRecord<Appointment>().HasSessions()
                ? "OPEN TREATMENT SESSION"
                : "CREATE TREATMENT SESSION";
                buttonTreatment.Visible = !gridAppointment.GetRecord<Appointment>().Cancelled;
            }
            else
            {
                return;
            }
        }

        private void buttonTreatment_Click(object sender, EventArgs e)
        {
            //for loading UI
            Cursor.Current = Cursors.WaitCursor;
            //get record of cell
            var record = gridAppointment.GetRecord<Appointment>();
            //open form frmTreatment and start waiting for close
            var frmTreatment = new Clinic_Mang_Sys.Forms.FrmTreatment(record);
            frmTreatment.FormTreatmentClosed += FrmTreatment_FormClosed;
            frmTreatment.ShowDialog();

        }

        //function waiting for FrmTreatment to be closed
        private void FrmTreatment_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }


        private void PageAppointments_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TestTheme_Click(object sender, EventArgs e)
        {//watch https://www.youtube.com/watch?v=8NA-H_3YtFg
            gridAppointment.AllowCustomTheming = false;
            gridAppointment.Theme = BunifuDataGridView.PresetThemes.Crimson;
            this.BackColor = ColorTranslator.FromHtml("#121212");
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = ColorTranslator.FromHtml("#121212"); // Change the color to the desired color
            }
        }
        public void ThemeChange()
        {
            ThemeHelper.ThemeDarkLight(this);

        }
        public void Lang_En()
        {
            //MessageBox.Show("tese");
            buttonAdd.Text = "ADD";
        }
        public void Lang_Ar()
        {
            buttonAdd.Text = "اضافة";

        }

    }
}
