using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> initialQualities = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            List<int> currentQualities = new List<int>(initialQualities);

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < currentQualities.Count; i++)
                {
                    currentQualities[i] -= hitPower;
                }

                for (int j = 0; j < currentQualities.Count; j++)
                {
                    double currentDrumPrice = 0;

                    if (currentQualities[j] <= 0)
                    {
                        currentDrumPrice = initialQualities[j] * 3;

                        if (currentDrumPrice <= savings)
                        {
                            savings -= currentDrumPrice;
                            currentQualities[j] = initialQualities[j];
                        }
                        else
                        {
                            currentQualities.RemoveAt(j);
                            initialQualities.RemoveAt(j);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" " , currentQualities));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
