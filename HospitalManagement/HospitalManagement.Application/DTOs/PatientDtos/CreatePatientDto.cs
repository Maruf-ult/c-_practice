using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.PatientDtos
{
    public class CreatePatientDto
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!; 
        public string Password { get; set; } = null!;
        public string Gender { get; set; }
        public AddressDto Address { get; set; } = null!;

    }
}
