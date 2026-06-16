using HospitalManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.PatientDtos
{
    public class UpdatePatientDto
    {
        public string Name { get; set; } = null!;
        public Genders Gender { get; set; };
        public AddressDto Address { get; set; } = null!;

    }
}
