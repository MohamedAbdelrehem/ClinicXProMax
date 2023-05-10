using System;
using System.Linq;
using Kimtoo.DbContext;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace Clinic_Mang_Sys.Models
{
    [Alias("Appointment")]
    public class Appointment
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        [ForeignKey(typeof(Patients), OnDelete = "CASCADE")]
        public int PatientId { get; set; }

        public string Notes { get; set; } = "";

        public DateTime Date { get; set; } = DateTime.Now;

        public string Time { get; set; } = "";
        public bool Cancelled { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Patients GetPatient() => Db.Get().SingleById<Patients>(this.PatientId);

        public Treatment GetTreatment() =>
            Db.Get().Single<Treatment>(r => r.AppointmentId == this.Id);

        public bool HasSessions() => GetTreatment() != null;
    }
}
