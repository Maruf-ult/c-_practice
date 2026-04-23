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
        public bool IsBooked { get;private set; }

        public Appointment(int appointmentid,  Patient patient, Doctor doctor, DateTime appointmentdate, string reason)
        {
            AppointmentId = appointmentid;
            Doctor = doctor;
            Patient = patient;
            AppointmentDate = DateTime.Now;
            Reason = reason;
            IsBooked = false;

        }

        public bool BookAppointment()
        {
            
            if(IsBooked)
            {
                Console.WriteLine("This appointment is already booked");
                return false;
            }
            IsBooked = true;
            Console.WriteLine("Appointment booked successfully");
            return true;
        }

        public void CancelAppointment()
        {
            if(!IsBooked)
            {
                Console.WriteLine("Appointment is not booked yet");
                return;
            }
            IsBooked = false;
            Console.WriteLine("Appointment canceled successfully");
        }

        public void ShowAppointmentInfo()
        {
            if (IsBooked == false)
            {
                Console.WriteLine("Take appointment first");
                return;
            }
            Console.WriteLine($"Appointment Id: {AppointmentId}");
            Console.WriteLine($"Doctor : {Doctor.Name}");
            Console.WriteLine($"Patient: {Patient.Name}");
            Console.WriteLine($"Appointment Date: {AppointmentDate}");
            Console.WriteLine($"Reason: {Reason}");
            Console.WriteLine($"Status: {(IsBooked?"Booked":"Canceled / Not booked")}");

        }



    }
}
