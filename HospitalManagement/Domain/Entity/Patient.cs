using HospitalManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Patient:BaseEntity
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public  Genders Gender { get; set; }
        public required Address Address { get; set; }
        public Bill? Bill { get; set; }
        public Guid? RoomId { get; set; }
        public Room? Room { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Prescription>Prescriptions { get; set;  } = new List<Prescription>();
        

    }
}
