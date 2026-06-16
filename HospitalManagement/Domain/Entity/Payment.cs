using HospitalManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Payment:BaseEntity
    {
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public Guid BillId { get; set; }
        public required Bill Bill { get; set; }
    }
}
