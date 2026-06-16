using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class CashPayment:Payment
    {
        public required string ReceiptNumber { get; set; };
    }
}
