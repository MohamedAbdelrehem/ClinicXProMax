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
using Clinic_Mang_Sys.Pages;

namespace Clinic_Mang_Sys.Forms
{
    public partial class FrmSettings : Form
    {
        public static FrmSettings instance;

        public FrmSettings()
        {
            InitializeComponent();
            instance = this;
            CheckEnableButton();


            /*
            string mode = Properties.Settings.Default.Mode;
            //ThemeChange();
            if (mode == "Dark")
            {
                btnToggleDark_LightMode.Checked = true;
            }
            else if (Application.UserAppDataRegistry.GetValue("Mode").ToString() == "Dark")
            {
                btnToggleDark_LightMode.Checked = false;
            }*/

        }



        private void btnToggleDark_LightMode_CheckedChanged(object sender, EventArgs e)
        {
            //Toggle between Light and Dark Mode
            if (Properties.Settings.Default.Mode == null || Properties.Settings.Default.Mode == "Light")
            {
                Properties.Settings.Default.Mode = "Dark";
                Properties.Settings.Default.Save();
                FrmMain.instance.ThemeChange();
                PageAppointments.instance.ThemeChange();

                imageMoon_dark.Visible = true;
                imageMoon_light.Visible = false;
                imageSun_dark.Visible = true;
                imageSun_light.Visible = false;
            }
            else
            {
                Properties.Settings.Default.Mode = "Light";
                Properties.Settings.Default.Save();
                FrmMain.instance.ThemeChange();

                imageMoon_dark.Visible = false;
                imageMoon_light.Visible = true;
                imageSun_dark.Visible = false;
                imageSun_light.Visible = true;
            }

            // Save the changes to the settings



            ThemeChange();

        }

        public void ThemeChange()
        {
            ThemeHelper.ThemeDarkLight(this);

        }
        private void CheckEnableButton()
        {
            string Lang = Properties.Settings.Default.Lang;
            if (Lang == "En")
            {
                btnEnglish.Enabled = false;
                btnArabic.Enabled = true;


            }
            else if (Lang == "Ar")
            {
                btnEnglish.Enabled = true;
                btnArabic.Enabled = false;

            }
        }
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "En";
            Properties.Settings.Default.Save();
            PageAppointments.instance.Lang_En();
            CheckEnableButton();
        }

        private void btnArabic_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "Ar";
            Properties.Settings.Default.Save();
            PageAppointments.instance.Lang_Ar();
            CheckEnableButton();
        }
    }


}
