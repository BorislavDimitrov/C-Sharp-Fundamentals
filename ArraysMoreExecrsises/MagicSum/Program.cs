using System;
using System.Linq;

namespace _MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length ; j++)
                {
                    if (i != j  && numbers[i] + numbers[j] == n)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                        
                        
                    }
                }
            }
        }
    }
} 
 

