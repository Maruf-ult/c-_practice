using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.PrescriptionDtos
{
    public class CreatePrescriptionDto
    {
        public Guid PatientId { get; set; }

        public Guid DoctorId { get; set; }

        public string Notes { get; set; } = null!;

        public ICollection<CreatePrescriptionMedicineDto> Medicines
        { get; set; } = new List<CreatePrescriptionMedicineDto>();
    }
}
