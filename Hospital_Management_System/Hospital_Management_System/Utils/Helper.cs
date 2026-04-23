using Hospital_Management_System.Models;
using Hospital_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Utils
{
    internal class Helper
    {
        InputRef input = new InputRef();


        public void ShowMenu()
        {
            Console.WriteLine("\n--- Hospital Management System ---");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Add Doctor");
            Console.WriteLine("3. Book Appointment");
            Console.WriteLine("4. Show Appointments");
            Console.WriteLine("5. Cancel Appointment");
            Console.WriteLine("6. Generate Bill");
            Console.WriteLine("7. Create Prescription");
            Console.WriteLine("8. Show All Patients");
            Console.WriteLine("9. Show All Doctors");
            Console.WriteLine("10. Show Patient History");
            Console.WriteLine("11. Exit");
        }

        public void AddPatient(HospitalService service)
        {
            int id = input.ReadInt("Enter patient Id:");
            string name = input.ReadString("Enter patient name:");
            int age = input.ReadInt("Enter patient age:");
            string email = input.ReadString("Enter email:");
            string phone = input.ReadString("Enter phone number:");
            string gender = input.ReadString("Enter Gender:");
            string bloodGroup = input.ReadString("Enter Blood group:");
            string history = input.ReadString("Enter medical history:");

            service.AddPatient(new Patient(id, name, age, email, phone, gender, bloodGroup, history));
        }

        public void AddDoctor(HospitalService service)
        {
            int id = input.ReadInt("Enter doctor Id:");
            string name = input.ReadString("Enter doctor name:");
            int age = input.ReadInt("Enter doctor age:");
            string email = input.ReadString("Enter email:");
            string phone = input.ReadString("Enter phone number:");
            string specialization = input.ReadString("Enter specialization:");
            decimal fee = input.ReadDecimal("Enter Consultation Fee:");

            service.AddDoctor(new Doctor(id, name, age, email, phone, specialization, fee));
        }

        public void BookAppointment(HospitalService service)
        {
            int pId = input.ReadInt("Enter Patient ID:");
            int dId = input.ReadInt("Enter Doctor ID:");
            int aId = input.ReadInt("Enter Appointment ID:");
            string reason = input.ReadString("Enter Reason:");

            service.BookAppointments(pId, dId, aId, DateTime.Now, reason);
        }

        public void CancelAppointment(HospitalService service)
        {
            int id = input.ReadInt("Enter Appointment ID to cancel:");
            service.CancelAppointment(id);
        }

        public void GenerateBill(HospitalService service)
        {
            int bId = input.ReadInt("Enter Bill ID:");
            int aId = input.ReadInt("Enter Appointment ID:");
            decimal med = input.ReadDecimal("Enter Medicine Charges:");
            decimal test = input.ReadDecimal("Enter Test Charges:");

            service.GenereateBill(bId, aId, 0, med, test);
        }

        public void CreatePrescription(HospitalService service)
        {
            int prId = input.ReadInt("Enter Prescription ID:");
            int aId = input.ReadInt("Enter Appointment ID:");
            string advice = input.ReadString("Enter Advice:");

            List<string> medicines = new List<string>();
            string addMore;
            do
            {
                medicines.Add(input.ReadString("Enter Medicine:"));
                addMore = input.ReadString("Add more? (y/n):").ToLower();
            } while (addMore == "y");

            service.CreatePrescription(prId, aId, medicines, advice);
        }

        public void ShowPatientHistory(HospitalService service)
        {
            int id = input.ReadInt("Enter Patient ID:");
            service.ShowPatientHistory(id);
        }

    }
}
