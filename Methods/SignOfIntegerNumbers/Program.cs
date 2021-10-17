using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SignOfInteger(num);
        }

        static void SignOfInteger(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }

    }
}
