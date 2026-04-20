using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Customer(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public void ShowCustomerInfo()
        {
            Console.WriteLine($"Id: {Id} \n Name: {Name} \n Phone: {Phone}");
        }
    }
}
