using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Mang_Sys.Pages
{
    public partial class PageDashboard : UserControl
    {
        public PageDashboard()
        {
            if (this.IsInDesignMode()) return;
            InitializeComponent();
        }
        /*private void LoadData()
        {
            var db = Connections.GetConnection();
        }*/
        private void PageDashboard_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //LoadData();
        }
    }
}
