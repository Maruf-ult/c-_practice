using HospitalManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.PatientDtos
{
    public class PatientDetailsDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public Genders Gender { get; set; }

        public AddressDto Address { get; set; } = null!;

        public RoomDto? Room { get; set; }

        public ICollection<AppointmentSummaryDto> Appointments
        { get; set; } = new List<AppointmentSummaryDto>();
    }
}
