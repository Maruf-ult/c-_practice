using Hospital_Management_System.Services;
using Hospital_Management_System.Utils;

namespace Hospital_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            InputRef input = new InputRef();
            HospitalService service = new HospitalService();

            /* 
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
             
             */

            bool processing = true;
            while (processing)
            {
                helper.ShowMenu();
                int choice = input.ReadInt("Choose option:");

                switch(choice)
                {
                    case 1:
                        helper.AddPatient(service);
                        break;

                    case 2:
                        helper.AddDoctor(service);
                        break;

                    case 3:
                        helper.BookAppointment(service);
                        break;

                    case 4:
                        service.ShowAppointments();
                        break;

                    case 5:
                        helper.CancelAppointment(service);
                        break;

                    case 6:
                        helper.GenerateBill(service);
                        break;

                    case 7:
                        helper.CreatePrescription(service);
                        break;

                    case 8:
                        service.ShowPatients();
                        break;

                    case 9:
                        service.ShowDoctors();
                        break;

                    case 10:
                        helper.ShowPatientHistory(service);
                        break;

                    case 11:
                        processing = false;
                        Console.WriteLine("Exiting.......");
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;

                }

            }
        }
    }
}
