﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicXProMax
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //init the connection
            //Connection.CheckAndCreateTable();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FrmMain());
        }

        public static bool IsInDesignMode(this UserControl container)
        {
            if (
                Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase)
                > -1
            )
            {
                container.Controls.Add(
                    new Label()
                    {
                        Text = container.GetType().Name,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    }
                );

                return true;
            }
            return false;
        }
    }
}
