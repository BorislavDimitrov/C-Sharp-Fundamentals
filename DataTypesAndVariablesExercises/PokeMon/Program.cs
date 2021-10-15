using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); 
            int distance = int.Parse(Console.ReadLine());  
            int exhaustingFactor = int.Parse(Console.ReadLine());

            double halfPower = pokePower * 0.50;
            int pokeCounts = 0;
            
            while (pokePower >= distance)
            {
                
                if (pokePower == halfPower && exhaustingFactor > 0)
                {
                        pokePower /= exhaustingFactor;
                    continue;
                }
                
                
                    pokePower -= distance;
                    pokeCounts++;
                
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounts);
        }
    }
}
