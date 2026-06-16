using HospitalManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.PatientDtos
{
    public class PatientResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public Genders Gender { get; set; }
    }
}
