using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Bill:BaseEntity
    {
        public decimal BillAmount { get; set; }
        public Guid PatientId { get; set; }
        public required Patient Patient { get; set; }
        public Payment? Payment { get; set; }
    }
}
