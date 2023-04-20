//using ServiceStack.DataAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Mang_Sys.Models
{
    //[AutoGenerateTable(2)]  from tool
    //[Alias("appointment")]  from tool
    public class Appointment
    {
        //[AutoIncrement, PrimaryKey] Tool
        public int Id { get; set; }
        //[ForeignKey(typeof(Patient), OnDelete = "CASCADE" ) ] Database
        public int PatientId { get; set; }

        public string Notes { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Now;

        public string Time { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
