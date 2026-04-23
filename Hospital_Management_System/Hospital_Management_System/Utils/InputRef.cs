using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Utils
{
    internal class InputRef
    {
        public int ReadInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if(int.TryParse(Console.ReadLine(),out int value))
                {
                    return value;
                }
                Console.WriteLine("Plz enter a valid number");
            }
        }

        public decimal ReadDecimal (string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if(decimal.TryParse(Console.ReadLine(),out decimal value))
                {
                    return value;
                }
                Console.WriteLine("Plz enter a valid decimal value");
            }
        }

        public string ReadString(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                Console.WriteLine("Input cannot be empty");
            }
        }

        public bool ReadBolean(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (bool.TryParse(Console.ReadLine(),out bool result))
                {
                    return result;
                }
                Console.WriteLine("plz enter true or false");
            }
        }


    }
}
