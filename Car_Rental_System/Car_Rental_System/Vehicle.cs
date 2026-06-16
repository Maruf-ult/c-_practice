using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal abstract class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        public string Model { get; set; }

        public bool IsAvailable { get; private set; }


        public  Vehicle(int id, string brand, string model)
        {
            Id = id;
            Brand = brand;
            Model = model;
            IsAvailable = true;
        }

        public virtual void ShowInfo()
        {
            string status = IsAvailable ? "Available" : "Rented";

            Console.WriteLine($"Id: {Id} \n Brand: {Brand}, \n Model: {Model} \n IsAvailable: {IsAvailable} \n Status: {status} ");
        }

        public void MarkRented()
        {
            IsAvailable = false;
        }

        public void MarkReturned()
        {
            IsAvailable = true;
        }

        public abstract decimal CalculateRent(int days);

    }
}
