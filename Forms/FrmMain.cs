using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Mang_Sys.Lib;

namespace Clinic_Mang_Sys
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            //to choose the language Temp
        }

        private void navigtionMenu1_OnItemSelected(object sender, string path, EventArgs e)
        {
            if (path == "Settings")
            {
                //for loading UI
                Cursor.Current = Cursors.WaitCursor;
                //new FrmSettings().ShowDialog();
                return;
            }
            bunifuAppBar1.Title = path;
            pages.SetPage(path);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            bunifuFormDock1.WindowState = Bunifu
                .UI
                .WinForms
                .BunifuFormDock
                .FormWindowStates
                .Maximized;
        }
    }
}
