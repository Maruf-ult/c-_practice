using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Models
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public Person(int id, string name,int age, string email,string phone)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
            Phone = phone;
        }

        public void ShowBasicInfo()
        {

            Console.WriteLine($"Id: {Id} \n Name: {Name} \n  Age: {Age} Email: {Email} \n Phone: {Phone}");
            
        }
    }
}
