using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class RentalService
    {
        List<Vehicle> vehicles = new List<Vehicle>() ;
        List<Customer> customers = new List<Customer>()  ;
        List<Rental> rentals = new List<Rental>();

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicle existingVehicle = vehicles.FirstOrDefault(v => v.Id == vehicle.Id);
            if(existingVehicle != null)
            {
                Console.WriteLine("This vehicles already exists");
                return;
            }
            vehicles.Add(vehicle);
            Console.WriteLine("Vehicle added successfully");
        }
        public void AddCustomer(Customer customer)
        {
            Customer existingCustomer = customers.FirstOrDefault(c => c.Id == customer.Id);
            if(existingCustomer != null)
            {
                Console.WriteLine("Customer already exists");
                return;
            }
            customers.Add(customer);
        }
        public void ShowAvailableVehicles()
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.IsAvailable)
                {
                    Console.WriteLine($"Id: {vehicle.Id}");
                    Console.WriteLine($"Name: {vehicle.Brand}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                }
            }
        }
        public void RentVehicle(int vehicled, int customerId, int days, IPayment payment)
        {

        }
        public void ShowRentalHistory()
        {

        }
        public void ShowAllVehicle()
        {
            if (vehicles.Count == 0)
            {
                Console.WriteLine("No vehicles added");
            }
            else
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    Console.WriteLine($"Id: {vehicle.Id}");
                    Console.WriteLine($"Name: {vehicle.Brand}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Available: { (vehicle.IsAvailable?"Yes":"No")}");

                }

        }
    }
}
