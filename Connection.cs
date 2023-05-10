using System;
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
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ClincX.mdf;Integrated Security=True;Connect Timeout=30",
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
