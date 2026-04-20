using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal interface IPayment
    {
         string PaymentType { get; }
         void Pay(decimal amount);
    }
}
