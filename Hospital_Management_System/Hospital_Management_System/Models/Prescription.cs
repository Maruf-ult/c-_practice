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

        public Prescription( int prescriptionId, Appointment appointment, List<string> medicines, string advice)
        {
            PrescriptionId = prescriptionId;
            Appointment = appointment;
            Medicines = medicines;
            Advice = advice;
        }

        public void ShowPrescription()
        {
            Console.WriteLine($"Prescription Id : {PrescriptionId}");
            Console.WriteLine($"Medicines: {Medicines}");
            Console.WriteLine($"Advice: {Advice}");
        }

    }
}
