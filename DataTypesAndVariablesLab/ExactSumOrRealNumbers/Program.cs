using System;
using System.Numerics;

namespace _03.ExactSumOrRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= nums; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
