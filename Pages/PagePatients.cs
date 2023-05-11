/*
    SELECT - extracts data from a database
    UPDATE - updates data in a database
    DELETE - deletes data from a database
    INSERT INTO - inserts new data into a database
    CREATE DATABASE - creates a new database
    ALTER DATABASE - modifies a database
    CREATE TABLE - creates a new table
    ALTER TABLE - modifies a table
    DROP TABLE - deletes a table
    CREATE INDEX - creates an index (search key)
    DROP INDEX - deletes an index
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Mang_Sys.Models;
using Kimtoo.BindingProvider;
using ServiceStack.OrmLite;
using System.Data.SqlClient;
using Kimtoo.DbContext;

namespace Clinic_Mang_Sys.Pages
{
    public partial class PagePatients : UserControl
    {
        //old SQL start connection
        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\github\C#\CLINICNEW\ClinicNew\ClincX.mdf;Integrated Security=True;Connect Timeout=30");

        public PagePatients()
        {
            if (this.IsInDesignMode())
                return;
            InitializeComponent();
            //gridPatients.DataSource = Patients;
            //LoadDataOld("select Name, Phone, Email, Address, DOB, Gender, Allergies,CreatedAt from Patients");
            LoadData();

            gridPatients.OnDelete<Patients>((a, b) => Db.Get().Delete(a) >= 0);
        }

        private void LoadData()
        {
            var data = Db.Get().Select<Patients>();
            gridPatients.Bind<Patients>(data);
        }

        private void LoadDataOld(string query)
        { /*
            /*Con.Open();
            string query = "select * from Patients";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gridPatients.DataSource = ds.Tables[0];
            Con.Close();*/
            // Con.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            DataTable dataTable = new DataTable();
            // adapter.Fill(dataTable);

            // Map the columns in the BunifuDataGridView control to the columns in the DataTable

            gridPatients.Columns["Column2"].DataPropertyName = "Name";
            gridPatients.Columns["Column5"].DataPropertyName = "Phone";
            gridPatients.Columns["Column3"].DataPropertyName = "Email";
            gridPatients.Columns["Column6"].DataPropertyName = "Address";
            gridPatients.Columns["Column7"].DataPropertyName = "DOB";
            gridPatients.Columns["Column9"].DataPropertyName = "Gender";
            gridPatients.Columns["Column11"].DataPropertyName = "Allergies";
            gridPatients.Columns["Column8"].DataPropertyName = "CreatedAt";
            gridPatients.DataSource = dataTable;
            // Con.Close();

            /*var db = Kimtoo.DbManager.Connections.GetConnection();
            List<Patients> data = db.Select<Patients>();
            gridPatients.Bind(data);*/



            //test data

            /*  List<Models.Appointment> data = new List<Models.Appointment>();

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

              gridPatients.Bind(data);*/
        } //Minimize bec (Depresed)

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlDrawwer.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDrawwer.Visible = true;
            bindingProvider1.Bind(new Patients());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check validation
            if (validationProvider1.Validate().Length > 0)
                return;

            var db = Db.Get();
            //var test = bindingProvider1.Get<Patients>();
            //Console.Write(test);
            bool SaveState = db.Save(bindingProvider1.Get<Patients>(), references: true);

            //get state of Data was edited or Inserted (new)
            string AddOrEditedMessage;
            if (SaveState)
            {
                AddOrEditedMessage = "Patient Added";
            }
            else
            {
                AddOrEditedMessage = "Patient updated";
            }

            LoadData();
            pnlDrawwer.Visible = false;

            //show AddOrEditedMessage
            bunifuSnackbar1.Show(
                this.FindForm(),
                AddOrEditedMessage,
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success
            );

            //Old Way
            /*
            //Sql maping
            Con.Open();
            string PatientName = NameTextBox.Text;
            string PatientPhone = PhoneTextBox.Text;
            string PatientEmail = EmailTextBox.Text;
            string PatientAddress = AddressTextBox.Text;
            DateTime PatientDOB = DOBDatePicker.Value;
            string PatientGender = GenderDropdown.SelectedItem.ToString();
            string PatientAllergies = AllergiesTextBox.Text;
            DateTime PatientCreatedAt = DateTime.Now;

            SqlCommand cmd = new SqlCommand(
                "insert into Patients (Name, Phone, Email, Address, DOB, Gender, Allergies, CreatedAt) values('"
                    + PatientName
                    + "','"
                    + PatientPhone
                    + "','"
                    + PatientEmail
                    + "', '"
                    + PatientAddress
                    + "', '"
                    + PatientDOB
                    + "', '"
                    + PatientGender
                    + "', '"
                    + PatientAllergies
                    + "','"
                    + PatientCreatedAt
                    + "')",
                Con
            );
            cmd.ExecuteNonQuery();
            Con.Close();
            //bunifuSnackbar1.s
            //LoadDataOld("select Name, Phone, Email, Address, DOB, Gender, Allergies,CreatedAt from Patients");
            LoadData();*/
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex == ColEdit.Index)
            {
                pnlDrawwer.Visible = true;
                bindingProvider1.Bind(gridPatients.GetRecord<Patients>());
            }
            if (e.ColumnIndex == ColDel.Index)
            {
                gridPatients.DeleteRow<Patients>();
            }
        }

        private void SearchTextBox_TextChange(object sender, EventArgs e)
        {
            // LoadDataOld("select Name, Phone, Email, Address, DOB, Gender, Allergies, CreatedAt from Patients where (Name LIKE '%' + '" + SearchTextBox.Text + "' + '%')");

            if (SearchTextBox.Text.Trim().Length > 0)
            {
                gridPatients.SearchRows(SearchTextBox.Text);
            }
            else
                LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            LoadData();
        }

    }
}
