using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            while (input != "END")
            {
                bool isInt = Int32.TryParse(input, out _ );
                bool isFloating = double.TryParse(input, out _);
                bool isBool = bool.TryParse(input , out _);
                bool isChar = char.TryParse(input , out _);

                if (isInt)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isFloating)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }

          
        }
    }
}
