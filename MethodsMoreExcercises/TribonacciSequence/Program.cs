using System;

namespace _TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (i - 1 < 0)
                {
                    numbers[i] += 0;
                }
                else
                {
                    numbers[i] += numbers[i - 1];
                }

                if (i - 2 < 0)
                {
                    numbers[i] += 0;
                }
                else
                {
                    numbers[i] += numbers[i - 2];
                }

                if (i - 3 < 0)
                {
                    numbers[i] += 0;
                }
                else
                {
                    numbers[i] += numbers[i - 3];
                }
            }

            Console.WriteLine(string.Join(" " , numbers));
        }
    }
}
