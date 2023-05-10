using System;
using ServiceStack.DataAnnotations;

namespace Clinic_Mang_Sys.Models
{
    [Alias("ClinicInfo")]
    public class ClinicInfo
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

        public byte[] Logo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
