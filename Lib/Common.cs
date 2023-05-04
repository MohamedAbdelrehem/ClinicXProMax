using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kimtoo.BindingProvider;

namespace Clinic_Mang_Sys.Lib
{
    public static class Common
    {
        public static DataGridViewAvatar GetAvatar(string Name) =>
            new DataGridViewAvatar { Value = Name, };
    }
}
