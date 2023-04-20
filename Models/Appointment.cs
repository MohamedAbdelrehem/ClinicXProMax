using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Clinic_Mang_Sys.Models {
//[AutoGenerateTable(2)]  from tool
[Alias("appointment")]
public class Appointment {
  [AutoIncrement, PrimaryKey]
  public int Id { get; set; }
  //[ForeignKey(typeof(Patient), OnDelete = "CASCADE" ) ] need Patient only
  public string Name { get; set; }

  public string Phone { get; set; } = "";
  public string Address { get; set; } = "";
  public string Email { get; set; } = "";

  public DateTime DOB { get; set; } = DateTime.Now;

  public string Gender { get; set; } = "";
  public DateTime CreatedAt { get; set; } = DateTime.Now;
}
}
