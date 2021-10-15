using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int littersInTAnk = 0;

            for (int i = 1; i <= num; i++)
            {
                int currentLittersToPour = int.Parse(Console.ReadLine());

                if (currentLittersToPour > tankCapacity - littersInTAnk)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    littersInTAnk += currentLittersToPour;
                }

            }
            Console.WriteLine(littersInTAnk);
        }
    }
}
