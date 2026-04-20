using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental_System
{
    internal class Rental
    {
        public int Rentalid { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public int Days { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime RentDate { get; set; }
        public bool IsReturned { get; private set; }
        public IPayment PaymentMethod { get; set; }

        public Rental(int rentalid,Customer customer,Vehicle vehicle,  int days,  IPayment paymentMethod)
        {
            Rentalid = rentalid;
            Customer = customer;
            Vehicle = vehicle;
            PaymentMethod = paymentMethod;
            Days = days;
            TotalCost = vehicle.CalculateRent(days);
            RentDate = DateTime.Now;
            IsReturned = false;
        }
        public void CreateRental()
        {
            Vehicle.MarkRented();
            PaymentMethod.Pay(TotalCost);
            Console.WriteLine("Rental created successfully");
        }
        public void CloseRental()
        {
            Vehicle.MarkReturned();
            IsReturned = true;
            Console.WriteLine("Vehicle returned successfully");

        }
        public void ShowRentalInfo()
        {
            Console.WriteLine($"Rental id: {Rentalid} ");
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Vehicle:{Vehicle.Brand}  {Vehicle.Model}");
            Console.WriteLine($"Days: {Days}");
            Console.WriteLine($"Total Cost: {TotalCost}");
            Console.WriteLine($"Payment: {PaymentMethod.PaymentType}");
            Console.WriteLine($"Rent Date: {RentDate}");
            Console.WriteLine($"Returned: {(IsReturned ? "Yes" : "No")}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
