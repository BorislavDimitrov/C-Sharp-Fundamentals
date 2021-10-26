using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            List<string> arrays = numbers.Split("|").ToList();
            arrays.Reverse();
            List<int> resultArrays = new List<int>();

            for (int i = 0; i < arrays.Count; i++)
            {
                string arrayElements = arrays[i];
                List<int> currentArray = arrayElements.Split(" " , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                currentArray.OrderBy(i => i);

                resultArrays.AddRange(currentArray);
            }
            Console.WriteLine(string.Join(" " , resultArrays));
        }
    }
}
