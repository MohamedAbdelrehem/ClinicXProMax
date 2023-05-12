using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kimtoo.DbContext;
using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

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
