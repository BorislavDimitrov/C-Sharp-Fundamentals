using System;

namespace _FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = Math.Abs(int.Parse(Console.ReadLine()));
            int secondNum = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine($"{Math.Abs(DividedFactorials(firstNum , secondNum)):F2}");
        }

        static double Factorial (int num)
        {
            double factorial = 1;
            

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static double DividedFactorials (int firstNum , int secondNum)
        {
            double sum = (Factorial(firstNum) / Factorial(secondNum));
            //sum = decimal.Parse(sum.ToString("f2"));
            return sum;
        }
    }
}
