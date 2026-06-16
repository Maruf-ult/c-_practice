using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Prescription:BaseEntity
    {
        public Guid PatientId { get; set; }
        public required Patient Patient { get; set; }
        public required Guid DoctorId { get; set; }
        public required Doctor Doctor { get; set; }
        public required string Notes { get; set; }
        public ICollection<PrescriptionMedicine> PrescriptionMedicines
        { get; set; } = new List<PrescriptionMedicine>();

    }
}
