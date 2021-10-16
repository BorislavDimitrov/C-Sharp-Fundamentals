using System;

namespace _PringNumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                nums[i] = currentNum;
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
