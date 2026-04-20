using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class Bus:Vehicle
    {
        public int Capacity { get; set; }

        public Bus(int id,string brand,string model,int capacity):base( id,brand,model)
        {
            Capacity = capacity;
        }

        public override decimal CalculateRent(int days)
        {
            return days * 1200;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Type: Bus, Capacity: {Capacity}");
        }
    }
}
