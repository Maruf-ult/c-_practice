using Hospital_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Services
{
    internal class HospitalService
    {
        List<Doctor> Doctors = new List<Doctor>();
        List<Patient> Patients = new List<Patient>();
        List<Appointment> Appointments = new List<Appointment>();
        List<Prescription> Prescriptions = new List<Prescription>();
        List<Bill> Bills = new List<Bill>();

        public void AddDoctor(Doctor doc)
        {
            Doctor ExistingDoc = Doctors.FirstOrDefault(d => d.Id == doc.Id);
            if(ExistingDoc != null)
            {
                Console.WriteLine("Doctor Already exists");
                return;
            }
            Doctors.Add(doc);
        }

        public void AddPatient(Patient pat)
        {
            Patient ExistingPatient = Patients.FirstOrDefault(p => p.Id == pat.Id);
            if (ExistingPatient != null)
            {
                Console.WriteLine("Patient Already exists");
                return;
            }
            Patients.Add(pat);
        }

        public void ShowDoctors()
        {
            if (Doctors.Count == 0)
            {
                Console.WriteLine("NO doctors available");
                return;
            }
            foreach(var doc in Doctors){
                doc.ShowDoctorInfo();
            }
        }

        public void ShowPatients()
        {
            if(Patients.Count == 0)
            {
                Console.WriteLine("No patients available");
                return;
            }
            foreach ( var pt in Patients)
            {
                pt.ShowPatientInfo();
            }
        }

        public void BookAppointments(int patientId, int doctorId, int appointmentId,DateTime appointmentDate, string  reason  )
        {
            Patient patient = Patients.FirstOrDefault(p => p.Id == patientId);
            Doctor doctor = Doctors.FirstOrDefault(d => d.Id == doctorId);
            if(patient == null)
            {
                Console.WriteLine("Patient not found");
                return;
            }
            if(doctor == null)
            {
                Console.WriteLine("Doctor not found");
                return;
            }

            bool appointmentExits = Appointments.Any(a => a.AppointmentId == appointmentId);

            if (appointmentExits)
            {
                Console.WriteLine("Appointment already booked");
                return;
            }

            Appointment appointment = new Appointment(appointmentId, patient, doctor, appointmentDate, reason);
            if (appointment.BookAppointment())
            {
                Appointments.Add(appointment);
                patient.PtAppointment.Add(appointment);
                doctor.DocAppointments.Add(appointment);

            }
            
        }

        public void ShowAppointments()
        {
            if (Appointments.Count == 0)
            {
                Console.WriteLine("No appointments available");
                return;
            }
            foreach ( Appointment appointment in Appointments)
            {
                appointment.ShowAppointmentInfo();
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            Appointment appointment = Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
            if (appointment == null)
            {
                Console.WriteLine("Appointment not found");
                return;
            }

            appointment.CancelAppointment();

        }

        public void GenereateBill(int billId , int appointmentId, decimal doctorFee, decimal medicineCharge, decimal testCharge)
        {
            
            Appointment app = Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);

            if(app == null)
            {
                Console.WriteLine("Appointment not found");
                return;
            }

            if (!app.IsBooked)
            {
                Console.WriteLine("Cannot generate bill for unbooked/canceled appointment ");
                return;
            }
            if(Bills.Any(b => b.BillId == billId))
            {
                Console.WriteLine("Bill already exits");
                return;
            }

            if(Bills.Any(b => b.Appointment.AppointmentId == appointmentId))
            {
                Console.WriteLine("Bills already genereaed for this appointment");
                return;
            }

            Bill bill = new Bill(
                billId,
                app,
                app.Doctor.ConsultationFee,
                medicineCharge,
                testCharge
                );

            bill.CalculateTotal();
            Bills.Add(bill);

            Console.WriteLine("Bills genereated successfully");
            bill.ShowBill();

        }

        public void CreatePrescription(int prescriptionId, int appointmentId,List<string>medicines,string advice)
        {
            Appointment app = Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);

            if(app == null)
            {
                Console.WriteLine("Appointment not found");
                return;
            }

            if (!app.IsBooked)
            {
                Console.WriteLine("Cannot generate prescription for unbooked/canceled appointment ");
                return;
            }

            if (Prescriptions.Any(p => p.PrescriptionId == prescriptionId))
            {
                Console.WriteLine("Prescription already exits");
                return;
            }

            if (Prescriptions.Any(p => p.Appointment.AppointmentId == appointmentId))
            {
                Console.WriteLine("prescription already genereaed for this appointment");
                return;
            }
            Prescription prescription = new Prescription(
                prescriptionId,
                app,
                advice
                );

            foreach( string medicine in medicines )
            {
                prescription.AddMedicine(medicine);
            }

            Prescriptions.Add(prescription);
            Console.WriteLine("Prescription created successfully");
            prescription.ShowPrescription();

        }

        public void ShowPatientHistory(int patientId)
        {
            Patient patient = Patients.FirstOrDefault(p => p.Id == patientId);
            var presctions = Prescriptions.Where(p => p.Appointment.Patient.Id == patientId).ToList();
            var bills = Bills.Where(b => b.Appointment.Patient.Id == patientId).ToList();
            if(patient == null)
            {
                Console.WriteLine("Patient not found");
                return;
            }
            Console.WriteLine("-------- Personal Info -------------");
            patient.ShowPatientInfo();
            Console.WriteLine();
            Console.WriteLine("-------- Prescriptions -------------");
            foreach( Prescription p in presctions)
            {
                p.ShowPrescription();
            }

            Console.WriteLine();
            Console.WriteLine("-------- Bills -------------");

            foreach ( Bill b in bills)
            {
                b.ShowBill();
            }


        } 
    }
}
