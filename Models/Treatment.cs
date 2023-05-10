using System;
using System.Collections.Generic;
using Kimtoo.DbContext;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace Clinic_Mang_Sys.Models
{
    [Alias("Treatment")]
    public class Treatment
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        [ForeignKey(typeof(Appointment), OnDelete = "CASCADE")]
        public int AppointmentId { get; set; }

        public string consultationNote { get; set; } = "";

        public string Prescriptions { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Appointment GetAppointment() => Db.Get().SingleById<Appointment>(this.AppointmentId);

        public Patients GetPatient() => GetAppointment().GetPatient();

        public List<Bill> GetBilling() => Db.Get().Select<Bill>(r => r.TreatmentId == this.Id);
    }
}
