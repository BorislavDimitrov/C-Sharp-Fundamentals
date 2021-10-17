using System;
using System.Linq;
using System.Text;

namespace _SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOfThreeNums(firstNum , secondNum , thirdNum));
        }
        static int SmallestOfThreeNums(int firstNum ,int secondNum , int thirdNum)
        {
            StringBuilder numbers = new StringBuilder();
            numbers.Append(firstNum + " ");
            numbers.Append(secondNum + " ");
            numbers.Append(thirdNum + " ");

            int[] nums = numbers.ToString().Split(" "  , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            
            return min;
        }
    }
}
