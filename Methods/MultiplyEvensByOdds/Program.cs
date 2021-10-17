using System;

namespace _MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyEvensByOdds(num));
        }

        static int MultiplyEvensByOdds( int num) 
        {
            int evenSum = 0;
            int oddSum = 0;
            while (num != 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    evenSum += Math.Abs(num % 10);
                    num /= 10;
                }
                else
                {
                    oddSum += Math.Abs(num % 10);
                    num /= 10;
                }  
            }
            int result = evenSum * oddSum;
            return result;
        }
    }
}
