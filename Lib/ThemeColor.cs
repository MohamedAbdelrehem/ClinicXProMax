using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Mang_Sys.Lib
{
    class ThemeColor
    {
        public static Color grayColor = Color.FromArgb(32, 30, 45);
        public static Color orangeColor = ColorTranslator.FromHtml("#FFBD2C");
        public static Color pinkColor = ColorTranslator.FromHtml("#E06488");
        public static Color cheryColor = ColorTranslator.FromHtml("#E23D4D");
        public static Color currentColor = grayColor;
    }
    public static class ThemeHelper
    {
        public static void ThemeDarkLight(Control parentControl)
        {
            //<<-----------------------------((Dark/Light))----------------------------->>

            // Read the user's preferred mode from a setting stored in the application configuration file
           // string mode = Properties.Settings.Default.Mode;

            // Apply the user's preferred mode to the parent control and its children
            /* if (mode == "Dark")
             {
                 parentControl.BackColor = Color.FromArgb(32, 30, 45);
                 parentControl.ForeColor = ThemeColor.orangeColor;
             }
             else
             {
                 parentControl.BackColor = Color.White;
                 parentControl.ForeColor = Color.Black;
             }

             // Recursively apply the theme to all child controls
             foreach (Control childControl in parentControl.Controls)
             {
                 ThemeDarkLight(childControl);
             }*/
            //<<-----------------------------((Dark/Light))----------------------------->>
        }

    }
}
