using System;
using System.Collections.Generic;
using System.Text;

namespace forOOP
{
    internal class Car
    {
        // Fields
        private string _brand = "";
        private string _model = "";
        private bool _isLuxury; 

        // Properties
        public string Brand
        {
            get => _isLuxury ? $"{_brand}_luxury edition" : _brand;
            set => _brand = string.IsNullOrWhiteSpace(value) ? "DEFAULT" : value;
        }

        public string Model { get => _model; set => _model = value; }
        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Constructor
        public Car(string brand, string model, bool isLuxury)
        {
            // Assigning values to the Properties so the 'set' logic triggers
            Brand = brand;
            Model = model;
            IsLuxury = isLuxury;

            Console.WriteLine($"Car object created: {Brand} {Model}");
        }

        // Instance Method (Removed 'static' so the specific car can drive)
        public void Drive()
        {
            Console.WriteLine($"The {Brand} is now driving.");
        }
    }
}
