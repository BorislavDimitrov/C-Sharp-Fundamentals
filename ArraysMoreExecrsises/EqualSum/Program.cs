using System;
using System.Linq;

namespace _EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isNo = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                string[] arrayIndesexses = new string[numbers.Length];
                for (int j = 0; j < i ; j++)
                {                   
                    leftSum += numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                 if (leftSum == rightSum)
                  {
                    Console.WriteLine(i);
                    isNo = false;
                    break;
                 }
            }
             if(isNo)
            {
                Console.WriteLine("no");
            }
        }
    }
}
