namespace struct___others
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point:  ({X},{Y})");
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }


    public class Point2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point:  ({X},{Y})");
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("FOr struct we test:");
            //Point p1 = new Point(10,20);
            //p1.Display();

            //Point p2 = new Point(20,30);
            //p2.Display();

            //Point p3 = p2;
            //p3.X = 30;
            //p2.Display();
            //p3.Display();



            //Console.WriteLine("FOr class we test:");
            //Point2 p4 = new Point2(10, 20);
            //p4.Display();

            //Point2 p5 = new Point2(20, 30);
            //p5.Display();

            //Point2 p6 = p4;
            //p6.X = 30;
            //p4.Display();
            //p6.Display();

            //DateTime dateTime = new DateTime(1988,5,31);
            //Console.WriteLine(dateTime);
            ////write today
            //Console.WriteLine(DateTime.Today);
            ////write today & current time
            //Console.WriteLine(DateTime.Now);

            ////get tommorow with static function
            //DateTime tommorow = GetTommorow();
            //Console.WriteLine(tommorow);

            ////get day of the week

            //Console.WriteLine(DateTime.Today.DayOfWeek);

            ////get how many days that month has
            //int days = DateTime.DaysInMonth(2000, 2);
            //Console.WriteLine(days);
            //days = DateTime.DaysInMonth(1900, 2);
            //Console.WriteLine(days);
            ////get minute 
            //Console.WriteLine(DateTime.Now.Minute);
            //Console.WriteLine(DateTime.Now.Hour);
            //Console.WriteLine(DateTime.Now.Second);
            //string input = Console.ReadLine();
            //if(DateTime.TryParse(input,out dateTime))
            //{
            //    Console.WriteLine(dateTime);
            //    TimeSpan daysPassed = DateTime.Now.Subtract(dateTime);
            //    Console.WriteLine(daysPassed.Days);
            //}


            Console.WriteLine(Math.Ceiling(10.3));
            Console.WriteLine(Math.Floor(10.3));
            Console.WriteLine(Math.Min(2,20));
            Console.WriteLine(Math.Max(2,20));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Abs(-20));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Cos(1));



            Console.ReadKey();

        }
        static DateTime GetTommorow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
