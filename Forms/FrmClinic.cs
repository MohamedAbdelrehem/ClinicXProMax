using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Clinic_Mang_Sys.Lib;
using Clinic_Mang_Sys.Models;
using Kimtoo.DbContext;
using ServiceStack.OrmLite;

namespace Clinic_Mang_Sys.Forms
{
    public partial class FrmClinic : Form
    {
        private ClinicInfo record;
        public FrmClinic()
        {
            InitializeComponent();
            this.record = Db.Get().Select<ClinicInfo>().FirstOrDefault();
            bindingProvider1.Bind(record);
            picLogo.Image = record.Logo.ToImage();
            Cursor.Current = Cursors.Default;
        }

        private void btnChangeLogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            picLogo.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            record.Logo = picLogo.Image.ToBytes();
            Db.Get().Save(record);
            bunifuSnackbar1.Show(this.FindForm(), "Saved", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

        }

        private void FrmClinic_Load(object sender, EventArgs e)
        {

        }
    }
}
