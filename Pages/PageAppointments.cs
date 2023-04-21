using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kimtoo.BindingProvider;

namespace Clinic_Mang_Sys.Pages
{
    public partial class PageAppointments : UserControl
    {
        public PageAppointments()
        {
            if (this.IsInDesignMode())
                return;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<Models.Appointment> data = new List<Models.Appointment>();

            for (int i = 0; i < 10; i++)
            {
                data.Add(
                    new Models.Appointment
                    {
                        Name = "memo" + i,
                        Address = "betna",
                        Email = "mohamed@gmail.com",
                        Phone = "01011929211"
                    }
                );
            }

            grid.Bind(data);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlDrawwer.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDrawwer.Visible = true;
        }
    }
}
