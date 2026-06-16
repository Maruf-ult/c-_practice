using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.PaymentDtos
{
    public class CreatePaymentDto
    {
        public Guid BillId { get; set; }

        public decimal Amount { get; set; }
    }
}
