using System;

namespace _AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(firstNum , secondNum , thirdNum));
        }

        static int Sum (int firstNum , int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }

        static int Subtract (int firstNum , int secondNum , int thirdNum)
        {
            int finalSum = Sum(firstNum, secondNum) - thirdNum;
            return finalSum;
        }
    }
}
