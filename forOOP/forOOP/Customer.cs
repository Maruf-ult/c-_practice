using System;
using System.Collections.Generic;
using System.Text;

namespace forOOP
{
    internal class Customer
    {
        private readonly int _id;
        private static int NextId;
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Customer(string name,string address="gerua",string phone="01232309283"){
            _id=NextId++;
            Name = name;
            Address = address;
            Phone = phone;
        }

        public Customer(string name)
        {
            _id = NextId++; 
            Name = name;
        }
        public static void SumOfNumbers(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine($"The sum of the number is {sum}");
        }
        public void GetUserDetails()
        {
            Console.WriteLine($"The user name is {Name} of user is : {_id}");
        }
    }
}
