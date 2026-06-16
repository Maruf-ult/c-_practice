namespace Events
{
    /// <summary>
    /// simple example of evenets
    /// </summary>
    class Button
    {
        public delegate void ClickHandler();
        public event ClickHandler Clicked;

        public void Click()
        {
            Console.WriteLine("Button clicked.");
            Clicked?.Invoke();
        }
    }

    /// <summary>
    /// simple example of events with parameter
    /// </summary>
    
    class OrderService
    {
        public delegate void OrderPlaceHandeler(int orderId, string customerName);
        public event OrderPlaceHandeler OrderPlaced;

        public void PlaceOrder(int orderId,string customerName)
        {
            Console.WriteLine($" order {orderId} is placed by {customerName}");

            OrderPlaced?.Invoke(orderId, customerName);
        }
    }


    internal class Program
    {
        static void showMessage()
        {
            Console.WriteLine("Event received: Button was clicked");
        }
        static void SendEmail(int orderId,string customerName)
        {
            Console.WriteLine($"Email send to {customerName} for ordering {orderId}");
        }
        static void SendSms(int orderId, string customerName)
        {
            Console.WriteLine($"Sms send to {customerName} for ordering {orderId}");
        }
        static void Main(string[] args)
        {
            //Button button = new Button();
            //button.Clicked += showMessage;
            //button.Click();

            OrderService orderService = new OrderService();
            orderService.OrderPlaced += SendEmail;
            orderService.OrderPlaced += SendSms;
            orderService.PlaceOrder(101,"saleque");
        }
    }
}
