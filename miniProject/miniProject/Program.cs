namespace miniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int[] temperatures = new int[days];
            string[] weather = { "Sunny", "Rainy", "Cloudy", "Snow" };
            string[] weatherconditions = new string[days];
            Random random = new Random();

            for(int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-4,40);
                weatherconditions[i] = weather[random.Next(weather.Length)];
            }
            for(int i = 0; i < days; i++)
            {
                Console.WriteLine(temperatures[i]);
            }
            for(int i = 0; i < days; i++)
            {
                Console.WriteLine(weatherconditions[i]);
            }

            Console.WriteLine($"The average temperature is {AvgTemperature(temperatures)} ");
            Console.WriteLine($"The minimum temperature is {temperatures.Min()}");
            Console.WriteLine($"The maximum temperature is {temperatures.Max()}");
            Console.WriteLine($"The most common wether conditons is {MostCommonCondition(weatherconditions)}");

        }
        public static double AvgTemperature(int[] temperatures)
        {
            int sum = 0;
            foreach(int temp in temperatures){
                sum += temp;
            }
            return (double) sum/temperatures.Length;
        }
        public static string MostCommonCondition(string[] weatherConditions)
        {
            var map = new Dictionary<string, int>();
            foreach(string w in weatherConditions)
            {
                if (map.ContainsKey(w))
                {
                    map[w]++;
                }
                else
                {
                    map[w] = 1;
                }
            }
            int mx = 0;
            string ans="";
            foreach(var g  in map)
            {
                if (g.Value > mx)
                {
                    mx = g.Value;
                    ans = g.Key;
                }
            }
            return ans;
        }
       
    }
}
