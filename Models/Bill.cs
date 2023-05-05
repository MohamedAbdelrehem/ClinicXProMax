using System;
using ServiceStack.DataAnnotations;

namespace Clinic_Mang_Sys.Models
{
    //[AutoGenerateTable(1)]
    [Alias("Bill")]
    public class Bill
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        [ForeignKey(typeof(Treatment), OnDelete = "CASCADE")]
        public int TreatmentId { get; set; }

        public string Description { get; set; } = "";
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
