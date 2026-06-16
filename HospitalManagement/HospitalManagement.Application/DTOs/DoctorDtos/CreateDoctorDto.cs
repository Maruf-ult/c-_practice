using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.DoctorDtos
{
    public class CreateDoctorDto
    {
        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Speciality { get; set; } = null!;

        public decimal VisitingFee { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid? SupervisorId { get; set; }
    }
}
