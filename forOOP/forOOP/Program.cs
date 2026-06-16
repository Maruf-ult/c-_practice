namespace forOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl","pahartuli");
            Customer maruf = new Customer("Maruf");

             Customer.SumOfNumbers(num1:23,num2:90);

            Car myAudi = new Car("audi", "r8", false);

            myAudi.Drive();

            Console.WriteLine($"Name of customer is {earl.Name}");
            Console.WriteLine(earl.Phone);
            earl.GetUserDetails();
            maruf.GetUserDetails();
            //Console.WriteLine("Name of customer is "+maruf.Name+maruf.Address+maruf.Phone);

        }
    }
}
