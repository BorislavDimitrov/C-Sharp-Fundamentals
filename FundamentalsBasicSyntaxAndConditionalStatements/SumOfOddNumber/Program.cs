using System;

namespace _0._9SumOfOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n * 2 - 1 ; i++)
            {
                if (i % 2 != 0 )
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
