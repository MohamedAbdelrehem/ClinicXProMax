using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Mang_Sys {
public partial class FrmMain : Form {
    public FrmMain() 
        { 
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelSettingSubsetting.Visible = false;
        }

        private void hideSubsetting()
        {
            if (panelSettingSubsetting.Visible == true)
                panelSettingSubsetting.Visible = false;
        }
        private void showSubsetting(Panel subsetting)
        {
            if (subsetting.Visible == false)
            {
                hideSubsetting();
                subsetting.Visible = true;

            }
            else
            {
                subsetting.Visible = false;
            }
        }

        private void Setting_page_Click(object sender, EventArgs e)
        {
            showSubsetting(panelSettingSubsetting);
        }

        private void Clinic_Subsetting_Click(object sender, EventArgs e)
        {
            hideSubsetting();
        }

        private void Program_Subsetting_Click(object sender, EventArgs e)
        {
            hideSubsetting();
        }

        private void About_Page_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }

}
