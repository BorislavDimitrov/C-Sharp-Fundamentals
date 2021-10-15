using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double diff = Math.Abs(numberA - numberB);
            double eps = 0.000001;
            

            if (diff < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
