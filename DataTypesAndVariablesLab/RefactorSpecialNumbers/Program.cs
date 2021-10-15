using System;

namespace _11.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
         
            for (int i = 1; i <= numbers; i++)
            {
                int currentNum = i;
                int currentNumSum = 0;
                bool isSpecial = false;

                while (currentNum > 0)
                {
                    currentNumSum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                if (currentNumSum == 5 || currentNumSum == 7 || currentNumSum == 11)
                {
                    isSpecial = true;
                }

                    Console.WriteLine("{0} -> {1}", i, isSpecial); 
            }

        }
    }
}
