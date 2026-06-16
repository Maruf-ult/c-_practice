using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Doctor:BaseEntity
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string Speciality { get; set; }
        public required decimal VisitingFee { get; set; }

        //department
        public Guid DepartmentId { get; set; }
        public required Department Department { get; set; }

        //self-reference(supervisor)
        public Guid? SupervisorId { get; set; }
        public Doctor? Supervisor { get; set; }

        public ICollection<Doctor> Subordinates { get; set; } = new List<Doctor>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}
