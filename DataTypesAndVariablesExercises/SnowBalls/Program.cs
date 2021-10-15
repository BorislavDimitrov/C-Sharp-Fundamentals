using System;
using System.Numerics;
namespace _11.SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballNum = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = BigInteger.Zero;
            int snowballSnow = int.MinValue;
            int snowballTime = int.MinValue;
            int snowballQuality = int.MinValue;

            for (int i = 1; i <= snowballNum; i++)
            {
                int currentSnowballSnow = int.Parse(Console.ReadLine());
                int currentSnowballTime = int.Parse(Console.ReadLine());
                int currentSnowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = BigInteger.Pow((currentSnowballSnow / currentSnowballTime), currentSnowballQuality);

                if (currentSnowballValue >= highestSnowballValue)
                {
                    highestSnowballValue = currentSnowballValue;
                    snowballSnow = currentSnowballSnow;
                    snowballTime = currentSnowballTime;
                    snowballQuality = currentSnowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnow} : {snowballTime} = {highestSnowballValue} ({snowballQuality})");
        }
    }
}
