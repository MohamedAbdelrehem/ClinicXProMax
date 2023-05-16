using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Mang_Sys.Models;
using Kimtoo.BindingProvider;
using Kimtoo.DbContext;
using ServiceStack.OrmLite;

namespace Clinic_Mang_Sys.Pages
{
    public partial class PageDashboard : UserControl
    {
        public PageDashboard()
        {
            if (this.IsInDesignMode()) return;
            InitializeComponent();

            gridRecentTransaction.CellFormatting += (obj, args) =>
            {
                if (
                    args.RowIndex >= 0
                    && /*Not the row header*/
                    args.ColumnIndex == 3
                    && /*Desired column Index*/
                    args.Value != null
                    && args.Value != DBNull.Value
                )
                {
                    args.Value = $"{args.Value} EGP";
                }
            };

        }
        private void LoadData()
        {
            var db = Db.Get();

            var appointments = db.Select<Appointment>();
            var patients = db.Select<Patients>();
            var billing = db.Select<Bill>();

            //update lables
            lblAppointmentsValue.Text = appointments.Count.ToString("N0");
            lblPatientsValue.Text = patients.Count.ToString("N0");
            lblBillingValue.Text = billing.Sum(r => r.Amount).ToString() + " EGP";

            lblActiveValue.Text = appointments.Where(r => !r.HasSessions() && !r.Cancelled).Count().ToString("N0");
            lblCompleteValue.Text = appointments.Where(r => r.HasSessions()).Count().ToString("N0");
            lblCancelledValue.Text = appointments.Where(r => r.Cancelled).Count().ToString("N0");

            gridNewPatient.Bind(patients.OrderByDescending(r => r.CreatedAt).Take(10));
            gridRecentTransaction.Bind(billing.OrderByDescending(r => r.CreatedAt).Take(10));

        }
        private void PageDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
