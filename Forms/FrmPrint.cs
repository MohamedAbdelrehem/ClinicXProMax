using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Clinic_Mang_Sys.Models;
using Clinic_Mang_Sys.Lib;
using Kimtoo.BindingProvider;
using Kimtoo.DbContext;
using ServiceStack.OrmLite;

namespace Clinic_Mang_Sys.Forms
{
    public partial class FrmPrint : Form
    {
        //private Treatment _treatment = null;
        public FrmPrint(Treatment treatment)
        {
            InitializeComponent();
            initializeCurrancy();
            LoadDocClinicData();
            LoadPatientTreatmentData(treatment);
            loadTotalBilling(treatment);

            Cursor.Current = Cursors.Default;
            gridTreatment.Bind(treatment.GetBilling());
        }
        private void LoadDocClinicData()
        {
            picLogo.Image = Db.Get().Select<ClinicInfo>().FirstOrDefault().Logo.ToImage();
            linkDocClinicName.Text = Db.Get().Select<ClinicInfo>().FirstOrDefault().Name;
            linkPhone.Text = Db.Get().Select<ClinicInfo>().FirstOrDefault().Phone;
            linkClinicAddress.Text = Db.Get().Select<ClinicInfo>().FirstOrDefault().Address;
        }
        private void LoadPatientTreatmentData(Treatment treatment)
        {
            bindingProvider1.Bind(treatment);
        }
        void loadTotalBilling(Treatment treatment)
        {
            lblTotal.Text = $"Total: {treatment.GetBilling().Sum(r => r.Amount).ToString()} EGP";
        }
        //<<-------------------------------------------(Currancy)------------------------------------------->>//
        private void initializeCurrancy()
        {
            string Lang = Properties.Settings.Default.Lang;
            //Intialize Currancey
            gridTreatment.Columns[2]
                .DefaultCellStyle
                .Format = "c2";

            if (Lang == "En")
            {
                gridTreatment.CellFormatting += (obj, args) =>
                {
                    if (
                        args.RowIndex >= 0
                        && /*Not the row header*/
                        args.ColumnIndex == 2
                        && /*Desired column Index*/
                        args.Value != null
                        && args.Value != DBNull.Value
                    )
                    {
                        args.Value = $"{args.Value} EGP";
                    }
                };
            }
            //For arabic version (Not finshed)
            else if (Lang == "Ar")
            {
                gridTreatment.Columns[2].DefaultCellStyle.FormatProvider =
                    CultureInfo.GetCultureInfo("ar-EG");
            }
        }

        //<<-------------------------------------------(Printing)------------------------------------------->>//

        private void Print(Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = panel;
            getPrintArea(panel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch (System.Exception)
            {

                MessageBox.Show("This File is opened you can't replace it");
            }


        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pageArea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            Print(this.panelPrint);
        }
        private Bitmap memoryImg;
        private void getPrintArea(Panel panel)
        {
            memoryImg = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryImg, new Rectangle(0, 0, panel.Width, panel.Height));
        }

    }
}
