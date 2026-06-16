using HospitalManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Appointment:BaseEntity
    {
        public Guid PatientId { get; set; }
        public required Patient Patient { get; set; }
        public Guid DoctorId { get; set; }
        public required Doctor Doctor { get; set; }
        public DateTime AppointmentTime { get; set; }
        public AppointmentStatus Status { get; set; }
    }
}
