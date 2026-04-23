using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Models
{
    internal class Prescription
    {
        public int PrescriptionId { get; set; }

        public Appointment Appointment { get; set; }

        public List<string> Medicines { get; set; }

        public string Advice { get; set; }

        public Prescription( int prescriptionId, Appointment appointment, string advice)
        {
            PrescriptionId = prescriptionId;
            Appointment = appointment;
            Medicines = new List<string>();
            Advice = advice;
        }

        public void AddMedicine(string medicine)
        {
            if (!string.IsNullOrWhiteSpace(medicine))
            {
                Medicines.Add(medicine);
            }
        }
        public void ShowPrescription()
        {
            Console.WriteLine($"Prescription Id : {PrescriptionId}");
            Console.WriteLine($"Appointment Id:{Appointment.AppointmentId}");
            Console.WriteLine($"Doctor: { Appointment.Doctor.Name}");
            Console.WriteLine($"Patient: {Appointment.Patient.Name}");
            Console.WriteLine("Medicines: ");

            foreach ( string med in Medicines)
            {
                Console.Write($"{med},  ");
            }
            Console.WriteLine();
            Console.WriteLine($"Advice: {Advice}");
        }

    }
}
