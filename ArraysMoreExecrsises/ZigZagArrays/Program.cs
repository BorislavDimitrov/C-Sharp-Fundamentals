using System;
using System.Linq;

namespace _ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if ((i + 1) % 2 != 0)
                {
                    firstArray[i] = currentNums[0];
                    secondArray[i] = currentNums[1];
                }
                else
                {
                    secondArray[i] = currentNums[0];
                    firstArray[i] = currentNums[1];
                }
            }
            Console.WriteLine(String.Join(" " , firstArray));
            Console.WriteLine(String.Join(" " , secondArray));
        }
    }
}
