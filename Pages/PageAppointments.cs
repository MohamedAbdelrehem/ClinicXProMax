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

        public DataGridViewAvatar GetAvatar(string Name) =>
            new DataGridViewAvatar { Value = Name, };

        private void LoadData()
        {
            List<Models.Appointment> data = new List<Models.Appointment>();

            for (int i = 0; i < 10; i++)
            {
                data.Add(
                    new Models.Appointment
                    {
                        Name = "memo",
                        Address = "betna",
                        Email = "mohamed@gmail.com",
                        Phone = "01011929211"
                    }
                );
            }

            grid.Bind(data);
        }
    }
}
