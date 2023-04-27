using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Clinic_Mang_Sys.Models;
using Kimtoo.BindingProvider;
using Kimtoo.DbContext;
using ServiceStack.OrmLite;

namespace Clinic_Mang_Sys.Pages
{
    public partial class PageAppointments : UserControl
    {
        public PageAppointments()
        {
            if (this.IsInDesignMode()) return;
            InitializeComponent();
            DateSwitch.Checked = true;
            PatientAppoimentDatePicker.Enabled = true;
            //set time picker to this date
            PatientAppoimentDatePicker.Value = DateTime.Now;

            //LoadData();
            gridAppointment.OnDelete<Appointment>((a, b) => Db.Get().Delete(a) >= 0);
        }

        private void LoadData()
        {

            //get data for shadowbox dropmenu
            PatientIdDropdown.DataSource = Db.Get().Select<Patients>();
            List<Appointment> data = Db.Get().Select<Appointment>();

            //get data for table

            if (DateSwitch.Checked == true)
            {
                data = data.Where(r => r.Date.Date == PatientAppoimentDatePicker.Value.Date).ToList();
            }



            if (TabGrid.CurrentSelection == "Pending")
            {
                data = data.Where(r => !r.HasSessions() && !r.Cancelled).ToList();
            }
            else if (TabGrid.CurrentSelection == "Complete")
            {
                data = data.Where(r => r.HasSessions() && !r.Cancelled).ToList();
            }
            else if (TabGrid.CurrentSelection == "Cancelled")
            {
                data = data.Where(r => r.Cancelled).ToList();

            }

            gridAppointment.Bind<Appointment>(data);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlDrawwer.Visible = false;
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientIdDropdown.DataSource = Db.Get().Select<Patients>();
            pnlDrawwer.Visible = true;
            bindingProvider1.Bind(new Appointment());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check validation
            if (validationProvider1.Validate().Length > 0) return;


            IDbConnection db = Db.Get();
            bool SaveState = db.Save(bindingProvider1.Get<Appointment>(), references: true);

            //get state of Data was edited or Inserted (new)
            string AddOrEditedMessage;
            if (SaveState) { AddOrEditedMessage = "Appointment Added"; }
            else { AddOrEditedMessage = "Appointment updated"; }

            LoadData();
            pnlDrawwer.Visible = false;

            //show AddOrEditedMessage
            bunifuSnackbar1.Show(this.FindForm(), AddOrEditedMessage, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex == ColEdit.Index)
            {
                pnlDrawwer.Visible = true;
                bindingProvider1.Bind(gridAppointment.GetRecord<Appointment>());
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

        private void btnRefresh_Click(object sender, EventArgs e)
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
            btnTreatment.Text = gridAppointment.GetRecord<Appointment>().HasSessions() ? "OPEN TREATMENT SESSION" : "CREATE TREATMENT SESSION";
            btnTreatment.Visible = !gridAppointment.GetRecord<Appointment>().Cancelled;
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            var record = gridAppointment.GetRecord<Appointment>();
        }
    }
}
