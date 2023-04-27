using System;
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
            LoadData();

            gridAppointment.OnDelete<Appointment>((a, b) => Db.Get().Delete(a) >= 0);
        }

        private void LoadData()
        {
            //get data for shadowbox dropmenu
            PatientIdDropdown.DataSource = Db.Get().Select<Patients>();

            //get data for table
            var data = Db.Get().Select<Appointment>();

            if (TabGrid.CurrentSelection == "Pending")
            {
                data = data.Where(r => !r.HasSessions() && r.Date < DateTime.Today).ToList();
            }
            else if (TabGrid.CurrentSelection == "Complete")
            {
                data = data.Where(r => r.HasSessions()).ToList();
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientIdDropdown.DataSource = Db.Get().Select<Patients>();
            pnlDrawwer.Visible = true;
            bindingProvider1.Bind(new Appointment());
        }

        private void GridTabs_OnSelectionChange(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
