using System;

namespace _MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char operatoR = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Calculations(firstNum , operatoR , secondNum)}");
        }

        static double Calculations(double firstNum , char operatoR , double secondNum) 
        {
            double sum = 0;
            if (operatoR == '+')
            {
                sum = firstNum + secondNum;
            }
            else if (operatoR == '-')
            {
                sum = firstNum - secondNum;
            }
            else if (operatoR == '*')
            {
                sum = firstNum * secondNum;
            }
            else if (operatoR == '/')
            {
                sum = firstNum / secondNum;
            }
            return sum;
        }
    }
}
