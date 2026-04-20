using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class Bike:Vehicle
    {
        public bool HasHelmet { get; set; }

        public Bike(int id,string brand,string model,bool hasHelmet):base(id,brand,model)
        {
            HasHelmet = hasHelmet;
        }

        public override decimal CalculateRent(int days)
        {
            return days * 300;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Type: Bike, HasHelmet: { (HasHelmet?"Yes":"No")}");
        }
    }
}
