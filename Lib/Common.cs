using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Mang_Sys.Lib
{
    public static class Common
    {

        public static Image ToImage(this byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Position = 0;
            return Image.FromStream(ms, true);
        }

        public static byte[] ToBytes(this Image imageIn)
        {

            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();

            }

        }
    }
}
