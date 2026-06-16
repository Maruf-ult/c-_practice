using HospitalManagement.Application.DTOs.DoctorDtos;
using HospitalManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.AppointmentDtos
{
    public class AppointmentResponseDto
    {
        public Guid Id { get; set; }

        public DateTime AppointmentTime { get; set; }

        public AppointmentStatus Status { get; set; }

        public PatientSummaryDto Patient { get; set; } = null!;

        public DoctorSummaryDto Doctor { get; set; } = null!;
    }
}
