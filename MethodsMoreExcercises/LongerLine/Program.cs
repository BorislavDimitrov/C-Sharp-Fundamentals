using System;

namespace _LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (DistanceBetweenTwoDots(x1 , y1 , x2 , y2) > DistanceBetweenTwoDots(x3 , y3 , x4 , y4))
            {
                if (ClosestToCenterPoint(x1, y1, x2, y2) == "first")
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (DistanceBetweenTwoDots(x3, y3, x4, y4) > DistanceBetweenTwoDots(x1, y1, x2, y2))
            {
                if (ClosestToCenterPoint(x3, y3, x4, y4) == "first")
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                
            }
            else if (DistanceBetweenTwoDots(x3, y3, x4, y4) == DistanceBetweenTwoDots(x1, y1, x2, y2))
            {
                if (ClosestToCenterPoint(x1, y1, x2, y2) == "first")
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }



        }


        static double DistanceBetweenTwoDots(double x1 , double y1 , double x2 , double y2) 
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }

        static string ClosestToCenterPoint(double x1, double y1, double x2, double y2)
        {
            double firstPointSum = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPointSum = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            string closesPoint = string.Empty;
            if (firstPointSum == secondPointSum)
            {
                closesPoint = "first";
            }
            else if (firstPointSum > secondPointSum)
            {
                closesPoint = "second";
            }
            else
            {
                closesPoint = "first";
            }

            return closesPoint;
        }
    }
}
