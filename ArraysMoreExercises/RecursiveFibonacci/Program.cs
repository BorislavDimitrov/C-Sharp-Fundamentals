using System;
using System.Linq;

namespace _RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 1; i < n; i++)
            {
                if (i == 1)
                {
                    a = 1;
                }
                else if (i == 2)
                {
                    b = 1;
                }

                c = a + b;
                if (i % 2 != 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
            }
            if (n == 0 || n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                 Console.WriteLine(c);   
            }
            
        }

    }
}
