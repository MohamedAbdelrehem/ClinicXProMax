using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using Kimtoo.DbContext;
using System.Windows.Forms;
using Clinic_Mang_Sys.Models;

namespace Clinic_Mang_Sys
{
    public static class Connection
    {
        static Connection()
        {
            try
            {
                var err = Db.Init(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\github\C#\ClinicXProMax\ClincX.mdf;Integrated Security=True;Asynchronous Processing=True;Connect Timeout=30",
                    SqlServerDialect.Provider
                );

                if (err != null)
                {
                    MessageBox.Show(err.Message);
                    Environment.Exit(0);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Environment.Exit(0);
            }
        }

        public static void CheckAndCreateTable()
        {
            var db = Db.Get();
            db.CreateTableIfNotExists<Patients>();
        }
    }
}
