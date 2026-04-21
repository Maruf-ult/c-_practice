using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class RentalService
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Customer> customers = new List<Customer>();
        List<Rental> rentals = new List<Rental>();

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicle existingVehicle = vehicles.FirstOrDefault(v => v.Id == vehicle.Id);
            if (existingVehicle != null)
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
            if (existingCustomer != null)
            {
                Console.WriteLine("Customer already exists");
                return;
            }
            customers.Add(customer);
        }
        public void ShowAvailableVehicles()
        {
            var availAbleVehicles = vehicles.Where(v => v.IsAvailable).ToList();

            if(availAbleVehicles.Count == 0)
            {
                Console.WriteLine("No available Vehicles Found");
                return;
            }

            foreach(var vehicle in availAbleVehicles)
            {
                vehicle.ShowInfo();
                Console.WriteLine();
            }
        }
        public void RentVehicle(int rentalId,int vehicleId, int customerId, int days, IPayment paymentMethod)
        {
            Vehicle vehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId);
            Customer customer = customers.FirstOrDefault(c => c.Id == customerId);

            if(vehicle == null)
            {
                Console.WriteLine("Vehicle not found");
                return;
            }
            if(customer == null)
            {
                Console.WriteLine("Customer not found");
                return;
            }
            if (!vehicle.IsAvailable)
            {
                Console.WriteLine("Vehicle is already rented");
                return;
            }
            Rental rental = new Rental(rentalId, customer, vehicle, days, paymentMethod);
            rental.CreateRental();
            rentals.Add(rental);
        }

        public void ReturnVehicle(int rentalId)
        {
            Rental rental = rentals.FirstOrDefault(r => r.Rentalid == rentalId);
            if(rental == null)
            {
                Console.WriteLine("Rental not found");
                return;
            }
            if (rental.IsReturned)
            {
                Console.WriteLine("Vehicle already returned");
                return;
            }
            rental.CloseRental();

        }
        public void ShowRentalHistory()
        {
            if (rentals.Count == 0)
            {
                Console.WriteLine("No rental history");
                return;
            }
            foreach (var rental in rentals)
            {
                rental.ShowRentalInfo();
            }
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
                    Console.WriteLine($"Available: {(vehicle.IsAvailable ? "Yes" : "No")}");

                }

            }
        }
    }
}
