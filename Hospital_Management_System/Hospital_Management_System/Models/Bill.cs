using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Models
{
    internal class Bill
    { 
        public int BillId { get; set; }
        public Appointment Appointment { get; set;  }
        public decimal DoctorFee { get; set; }
        public decimal MedicineCharge { get; set; }
        public decimal TestCharge { get; set; }
        public decimal Amount { get; set; }

        public void CalculateTotal()
        {
            decimal total = DoctorFee + MedicineCharge + TestCharge + Amount;
            Console.WriteLine($"Total Charge: {total}");
        }

        public void ShowBill()
        {
            Console.WriteLine($"Bill Id: {BillId} \n Appointment: {Appointment} \n ");
            CalculateTotal();
        }

    }
}
