using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int minedAmount = 0;
            int currentMiningAmount = startingYield;
            int daysMined = 0;

            while (currentMiningAmount >= 100)
            {
                daysMined++;
                minedAmount += currentMiningAmount;
                currentMiningAmount -= 10;
                minedAmount -= 26;
            }
            if (daysMined > 0)
            {
                minedAmount -= 26;
            }
            Console.WriteLine(daysMined);
            Console.WriteLine(minedAmount);
        }
    }
}
