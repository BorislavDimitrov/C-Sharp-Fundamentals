using System;

namespace _PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                int num = int.Parse(input);
                if (CheckIfPalindrome(num))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }
        }

        static bool CheckIfPalindrome (int num)
        {
            bool isPalindrome = false;
            string reverseNum = string.Empty;
             reverseNum += $"{num}";
            string realReverse = string.Empty;

            for (int i = reverseNum.Length - 1; i >= 0; i--)
            {
                realReverse += reverseNum[i];
            }
            int finalReverse = 0;
            bool isNum = int.TryParse(realReverse, out finalReverse);
            if (finalReverse == num)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
