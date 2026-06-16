using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.AppointmentDtos
{
    public class CreateAppointmentDto
    {
        public Guid PatientId { get; set; }

        public Guid DoctorId { get; set; }

        public DateTime AppointmentTime { get; set; }
    }
}
