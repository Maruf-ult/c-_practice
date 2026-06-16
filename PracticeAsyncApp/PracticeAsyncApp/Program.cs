namespace PracticeAsyncApp
{
    internal class Program
    {
        static async Task<string> GetUserAsync()
        {
            await Task.Delay(1000);
            return "Profile loaded";
        }

        static async Task<string> GetProductAsync()
        {
            await Task.Delay(2000);
            return "Product loaded";
        }
        static async Task<string> GetOrderAsync()
        {
            await Task.Delay(3000);
            return "Order loaded";
        }

        static async Task<string> StudentAsync()
        {
            await Task.Delay(3000);
            return "student loaded";
        }

        static async Task<string> GetMarkAsync()
        {
            await Task.Delay(4000);
            return "Mark loadded";
        }

        static async Task<string> GetAttendenceAsync()
        {
            await Task.Delay(2000);
            return "Attendence loaded";
        }

        static async Task Main(string[] args)
        {
            Task<string> user = GetUserAsync();
            Task<string> product = GetProductAsync();
            Task<string> order = GetOrderAsync();

            await Task.WhenAll(user, product, order);

            Console.WriteLine(await user);
            Console.WriteLine(await product);
            Console.WriteLine(await order);

            string result = await StudentAsync();
            Console.WriteLine(result);
        }
    }
}
