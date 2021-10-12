using System;

namespace _0._8DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
