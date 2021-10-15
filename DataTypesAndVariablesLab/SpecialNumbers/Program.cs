using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = false;
                int currentNumSum = 0;
                int currentNumLength = i.ToString().Length;
                string currentNum = i.ToString();

                for (int j = 0; j <= currentNumLength - 1; j++)
                {
                    int currentIndex = int.Parse(currentNum[j].ToString());
                    currentNumSum += currentIndex;

                }

                if (currentNumSum == 5 || currentNumSum == 7 || currentNumSum == 11)
                {
                    isSpecial = true;
                }

                if (isSpecial)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
            if (n == 0)
            {
                Console.WriteLine("0 -> False");
            }
        }
    }
}