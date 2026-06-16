using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class PrescriptionMedicine
    {
        public Guid PrescriptionId { get; set; }
        public Prescription Prescription { get; set; } = null!;

        public Guid MedicineId { get; set; }
        public Medicine Medicine { get; set; } = null!;

        public int Dose { get; set; }
        public int DurationInDays { get; set; }
    }
}
