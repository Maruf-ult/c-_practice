using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class Car:Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Car(int id,string brand, string model, int numberOfSeats):base(id,brand,model)
        {   
            NumberOfSeats = numberOfSeats;
        }
        public override decimal CalculateRent(int days)
        {
            return days * 1000;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Type: Car, Seats:{NumberOfSeats}");
        }
    }
}
