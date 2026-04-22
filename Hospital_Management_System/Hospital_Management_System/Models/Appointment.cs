using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Models
{
    internal class Appointment
    {
        public int AppointmentId { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Reason { get; set; }
        public bool Status { get;private set; }

        public Appointment(int appointmentid, Doctor doctor, Patient patient, DateTime appointmentdate, string reason)
        {
            AppointmentId = appointmentid;
            Doctor = doctor;
            Patient = patient;
            AppointmentDate = DateTime.Now;
            Reason = reason;
            Status = false;

        }

        public void BookAppointment()
        {
            
            if(Status == true)
            {
                Console.WriteLine("Doctor already has an appointment");
                return;
            }
            Status = true;
        }

        public void CancelAppointment()
        {
            if(Status == false)
            {
                Console.WriteLine("Appointment is not taken yet");
                return;
            }
            Status = false;
        }

        public void ShowAppointmentInfo()
        {
            if (Status == false)
            {
                Console.WriteLine("Take appointment first");
                return;
            }
            Console.WriteLine($"Appointment Id: {AppointmentId}");
            Console.WriteLine($"Doctor : {Doctor}");
            Console.WriteLine($"Patient: {Patient}");
            Console.WriteLine($"Appointment Date: {AppointmentDate}");
            Console.WriteLine($"Reason: {Reason}");
            Console.WriteLine($"Status: {Status}");

        }



    }
}
