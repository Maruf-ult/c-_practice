using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class CardPayment:Payment
    {
        public required string CardNumber { get; set; }
    }
}
