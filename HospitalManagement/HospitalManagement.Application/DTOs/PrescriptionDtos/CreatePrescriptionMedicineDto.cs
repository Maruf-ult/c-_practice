using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.PrescriptionDtos
{
    public class CreatePrescriptionMedicineDto
    {
        public Guid MedicineId { get; set; }

        public decimal DoseAmount { get; set; }

        public string DoseUnit { get; set; } = null!;

        public int DurationInDays { get; set; }

        public string? Instructions { get; set; }
    }
}
