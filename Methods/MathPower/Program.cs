using System;

namespace _MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int raisePower = int.Parse(Console.ReadLine());
            Console.WriteLine(RaisedPower(n , raisePower));
        }

        static double RaisedPower (double n , int raisePower) 
        {
            double result = Math.Pow(n, raisePower);
            return result;
        }
    }
}
