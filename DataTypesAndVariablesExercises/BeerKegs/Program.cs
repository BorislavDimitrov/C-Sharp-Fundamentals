using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal biggestVolume = decimal.MinValue;
            string biggestKegModel = string.Empty;

            for (int i = 1; i <= num; i++)
            {
                string currentKegModel = Console.ReadLine();
                double currentKegRadius = double.Parse(Console.ReadLine());
                int currentKegHeight = int.Parse(Console.ReadLine());
                
                decimal currentKegVolume = (decimal)Math.PI * (decimal)(currentKegRadius * currentKegRadius) * currentKegHeight;

                if (currentKegVolume > biggestVolume)
                {
                    biggestVolume = currentKegVolume;
                    biggestKegModel = currentKegModel;
                }
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
