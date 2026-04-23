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
        public decimal TotalAmount { get; private set; }

        public Bill(int billId,Appointment appointment,decimal doctorFee,decimal medicineCharge,decimal testCharge)
        {
            BillId = billId;
            Appointment = appointment;
            DoctorFee = doctorFee;
            MedicineCharge = medicineCharge;
            TestCharge = testCharge;
            TotalAmount = 0;
        }

        public void CalculateTotal()
        {
            TotalAmount = DoctorFee + MedicineCharge + TestCharge + TotalAmount;
            
        }

        public void ShowBill()
        {
            Console.WriteLine($"Bill Id: {BillId}");
            Console.WriteLine($"Appointment Id: {Appointment.AppointmentId}");
            Console.WriteLine($"Doctor: {Appointment.Doctor.Name}");
            Console.WriteLine($"Patient: {Appointment.Patient.Name}");
            Console.WriteLine($"Doctor Fee: {DoctorFee}");
            Console.WriteLine($"Medicine Charge: {MedicineCharge}");
            Console.WriteLine($"Test Charge: {TestCharge}");
            Console.WriteLine($"Total Amount: {TotalAmount}");
            Console.WriteLine("--------------------------------");
        }

    }
}
