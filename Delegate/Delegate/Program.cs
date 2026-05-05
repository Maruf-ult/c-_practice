namespace Delegate
{
    internal class Program
    {
        delegate double mathOperation(double a,double b);
        delegate void NotificationDelegate(string msg);
        
        static double Add(double a,double b)
        {
            return a + b;
        }

        static double Substract(double a,double b)
        {
            return a - b;
        }

        static double Multiply(double a,double b)
        {
            return a * b;
        }

        static double Divided(double a,double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cant be zero");
            }
            return (a / b);
        }

        static void ShowMission()
        {
            Console.WriteLine("Mission Kadal");
        }

        static bool IsPaka(int age)
        {
            return age >= 2;
        }

        static void SendEmail(string msg)
        {
            Console.WriteLine($"Email sent: {msg} ");
        }

        static void SendSms(string msg)
        {
            Console.WriteLine($"Sms sent: {msg} ");
        }

        static void SendPushNotification(string msg)
        {
            Console.WriteLine($"push notification sent your msg: {msg}");
        }

        static void Main(string[] args)
        {
            mathOperation operation;

            operation = Add;
            Console.WriteLine(operation(5,6));

            operation = Substract;
            Console.WriteLine(operation(10,5));

            operation = Multiply;
            Console.WriteLine(operation(5, 5));

            operation = Divided;
            Console.WriteLine(operation(30, 5));

            Action mis = ShowMission;
            mis();

            Func<double, double, double> addFunc = Add;
            double result = addFunc(10,10);
            Console.WriteLine(result);

            Predicate<int> checkPaka = IsPaka;
            Console.WriteLine(checkPaka(1));

            NotificationDelegate notify = SendEmail;

            notify += SendSms;
            notify += SendSms;

            notify += SendPushNotification;
            notify -= SendSms;

            notify("Your order has been confirmed");

        }
    }
}
