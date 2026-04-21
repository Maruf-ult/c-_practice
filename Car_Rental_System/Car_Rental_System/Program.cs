namespace Car_Rental_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalService service = new RentalService();
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Car Rental System  ---");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Add Bike");
                Console.WriteLine("3. Add Bus");
                Console.WriteLine("4. Add Customer");
                Console.WriteLine("5. Show All Vehicles");
                Console.WriteLine("6. Show Available Vehicles");
                Console.WriteLine("7. Rent Vehicle");
                Console.WriteLine("8. Return Vehicle");
                Console.WriteLine("9. Show Rental History");
                Console.WriteLine("10. Exit");
                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Car ID: ");
                        int carId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Brand: ");
                        string carBrand = Console.ReadLine();

                        Console.Write("Enter Model: ");
                        string carModel = Console.ReadLine();

                        Console.Write("Enter Number of Seats: ");
                        int seats = int.Parse(Console.ReadLine());

                        service.AddVehicle(new Car(carId, carBrand, carModel, seats));
                        break;

                    case 2:
                        Console.Write("Enter Bike ID: ");
                        int bikeId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Brand: ");
                        string bikeBrand = Console.ReadLine();

                        Console.Write("Enter Model: ");
                        string bikeModel = Console.ReadLine();

                        Console.Write("Has Helmet? (true/false): ");
                        bool hasHelmet = bool.Parse(Console.ReadLine());

                        service.AddVehicle(new Bike(bikeId, bikeBrand, bikeModel, hasHelmet));
                        break;

                    case 3:
                        Console.Write("Enter Bus ID: ");
                        int busId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Brand: ");
                        string busBrand = Console.ReadLine();

                        Console.Write("Enter Model: ");
                        string busModel = Console.ReadLine();

                        Console.Write("Enter Capacity: ");
                        int capacity = int.Parse(Console.ReadLine());

                        service.AddVehicle(new Bus(busId, busBrand, busModel, capacity));
                        break;

                    case 4:
                        Console.Write("Enter Customer ID: ");
                        int customerId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Customer Name: ");
                        string customerName = Console.ReadLine();

                        Console.Write("Enter Phone: ");
                        string phone = Console.ReadLine();

                        service.AddCustomer(new Customer(customerId, customerName, phone));
                        break;

                    case 5:
                        service.ShowAllVehicle();
                        break;

                    case 6:
                        service.ShowAvailableVehicles();
                        break;

                    case 7:
                        Console.Write("Enter Rental ID: ");
                        int rentalId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Vehicle ID: ");
                        int rentVehicleId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Customer ID: ");
                        int rentCustomerId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Number of Days: ");
                        int days = int.Parse(Console.ReadLine());

                        Console.Write("Payment Method (cash/card): ");
                        string paymentChoice = Console.ReadLine().ToLower();

                        IPayment paymentMethod;
                        if (paymentChoice == "cash")
                        {
                            paymentMethod = new CashPayment();
                        }
                        else
                        {
                            paymentMethod = new CardPayment();
                        }

                        service.RentVehicle(rentalId, rentVehicleId, rentCustomerId, days, paymentMethod);
                        break;

                    case 8:
                        Console.Write("Enter Rental ID to return: ");
                        int returnRentalId = int.Parse(Console.ReadLine());

                        service.ReturnVehicle(returnRentalId);
                        break;

                    case 9:
                        service.ShowRentalHistory();
                        break;

                    case 10:
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;

                }
            }
        }
    }
}
