using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Mang_Sys.Forms
{
    public partial class Clinic : Form
    {
        Clinic record;  

        public Clinic()
        {
            InitializeComponent();
            this.record = Connections.GetConnection().Select<Clinic>(),firstOrDefault();
            bindingprovider1.Bind(record);  
        }


        private void Clinic_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog5_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Pic1Logo.Image = Image.FromFile(openFileDialog1.FileName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void btnSave_Click(object sender, EventArgs e)
            Connections.GetConnection().Save(record);
        {

        }
    }
}
