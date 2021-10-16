using System;
using System.Linq;

namespace _ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentIndex = numbers[0];
                for (int j = 0; j < numbers.Length - 1; j++)  
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = currentIndex;
                
            }
            Console.WriteLine(String.Join(" " , numbers));
        }
    }
}
