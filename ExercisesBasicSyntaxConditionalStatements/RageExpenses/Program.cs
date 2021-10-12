using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsetCount = 0;
            int trashedMouseCount = 0;
            int trashedKeyboardCount = 0;
            int trashedDisplayCount = 0;
            int previousTimeCrached = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadsetCount++;
                }
                if (i % 3 == 0)
                {
                    trashedMouseCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboardCount++;
                }
                if (trashedKeyboardCount % 2 == 0 && trashedKeyboardCount > previousTimeCrached)
                {
                     previousTimeCrached = trashedKeyboardCount;
                    trashedDisplayCount++;
                }
            }

            double expenses = (trashedHeadsetCount * 1.00 * headsetPrice) + (trashedMouseCount * 1.00 * mousePrice) + (trashedKeyboardCount * 1.00 * keyboardPrice) + (trashedDisplayCount * 1.00 * displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
