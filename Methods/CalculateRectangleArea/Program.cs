using System;

namespace _CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            RectangleleArea(width, height);
        }

        static void RectangleleArea(int width, int height) 
        {
            int area = width * height;
            Console.WriteLine(area);
        }
    }
}
