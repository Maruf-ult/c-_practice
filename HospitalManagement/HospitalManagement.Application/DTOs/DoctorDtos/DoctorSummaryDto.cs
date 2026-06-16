using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.DoctorDtos
{
    public class DoctorSummaryDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Speciality { get; set; } = null!;
    }
}
