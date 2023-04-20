using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Clinic_Mang_Sys.Models
{
    //[AutoGenerateTable(2)]  from tool
    [Alias("appointment")]
    public class Appointment
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        //[ForeignKey(typeof(Patient), OnDelete = "CASCADE" ) ] need Patient only
        public int PatientId { get; set; }

        public string Notes { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Now;

        public string Time { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
