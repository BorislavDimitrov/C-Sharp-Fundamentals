using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> order = numbers.OrderByDescending(x => x).ToList();

            if (order.Count > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(order[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < order.Count; i++)
                {
                    Console.Write(order[i] + " ");
                }
            }
        }
    }
}
