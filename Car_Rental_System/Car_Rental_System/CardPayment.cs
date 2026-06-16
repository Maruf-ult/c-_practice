using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class CardPayment:IPayment
    {
        public string PaymentType => "Card";

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} BDT by card.");
        }
    }
}
