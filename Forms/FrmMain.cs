using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Clinic_Mang_Sys.Forms;
using Clinic_Mang_Sys.Lib;
using Clinic_Mang_Sys.Models;
using Kimtoo.DbContext;
using Kimtoo.DbManager;
using ServiceStack.OrmLite;

namespace Clinic_Mang_Sys
{
    public partial class FrmMain : Form
    {
        public static FrmMain instance;
        public FrmMain()
        {

            try
            {
                if (Db.Get().Select<ClinicInfo>().Count() == 0)
                    Db.Get().Save(
                    new ClinicInfo
                    {
                        Name = "Clinic X Pro Max",
                        Email = "clinicxpromax@gmail.com",
                        Password = "clinicadmin1",
                        Address = "Giza. EG",
                        Logo = Image.FromFile("logo.png").ToBytes(),
                        Phone = "01011929211",
                    }
                    );

            }
            catch (Exception)
            {

                //Connections.Show();
            }

            //to choose the language Temp
            InitializeComponent();

            instance = this;
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
            picLogo.Image = Db.Get().Select<ClinicInfo>().FirstOrDefault().Logo.ToImage();

            //debuging login for speed :)
#if DEBUG
            EmailTextBox.Text = "clinicxpromax@gmail.com";
            PasswordTextBox.Text = "clinicadmin1";
#endif

        }

        public void ThemeChange()
        {
            ThemeHelper.ThemeDarkLight(this);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //not empty
            if (validationProvider1.Validate().Length > 0) return;

            var record = Db.Get().Select<ClinicInfo>().FirstOrDefault();
            if (record.Email.ToLower() != EmailTextBox.Text.ToLower() || record.Password.ToLower() != PasswordTextBox.Text.ToLower())
            {
                //show AddOrEditedMessage
                bunifuSnackbar1.Show(this.FindForm(), "Incorrect username or password", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            pages.SetPage("Dashboard");
            bunifuAppBar1.Title = "Dashboard";
            Menu.Enabled = true;
            bunifuSnackbar1.Show(this.FindForm(), "Welcome Back", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

        }

        private void Menu_OnItemSelected(object sender, string path, EventArgs e)
        {
            if (path == "Settings.Personalization")
            {
                //for loading UI
                Cursor.Current = Cursors.WaitCursor;
                //new FrmSettings().ShowDialog();
                return;
            }
            if (path == "Settings.Clinic")
            {
                //for loading UI
                Cursor.Current = Cursors.WaitCursor;
                new FrmClinic().ShowDialog();
                return;
            }
            bunifuAppBar1.Title = path;
            pages.SetPage(path);
        }
    }
}
