using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class CashPayment:IPayment
    {
        public string PaymentType => "Cash";

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paied {amount}BDT by cash.");
        }
    }
}
