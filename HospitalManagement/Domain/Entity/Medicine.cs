using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Medicine:BaseEntity
    {
        public required string Name { get; set; }
        public string ? GenericName { get; set; }
        public required string CompanyName { get; set; }
        public required decimal Price { get; set; }

        public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = new List<PrescriptionMedicine>();



    }
}
