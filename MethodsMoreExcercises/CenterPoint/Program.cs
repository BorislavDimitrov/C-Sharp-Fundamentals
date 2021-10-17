using System;

namespace _CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            ClosestToCenterPoint(x1 , y1 , x2 , y2);
        }

        static void ClosestToCenterPoint (double x1 , double y1 , double x2 , double y2)
        {
            double firstPointSum = Math.Sqrt(Math.Pow(x1 , 2) + Math.Pow(y1 , 2));
            double secondPointSum = Math.Sqrt(Math.Pow(x2 , 2) + Math.Pow(y2 , 2));

            if (firstPointSum == secondPointSum)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (firstPointSum > secondPointSum)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
