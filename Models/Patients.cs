using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Clinic_Mang_Sys.Models
{
    //[AutoGenerateTable(0)]
    [Alias("Patients")]
    public class Patients
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        [ForeignKey(typeof(Patients), OnDelete = "CASCADE")]
        public string Name { get; set; } = "";

        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";

        public DateTime DOB { get; set; } = DateTime.Now;
        public string Gender { get; set; } = "";
        public string Allergies { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
