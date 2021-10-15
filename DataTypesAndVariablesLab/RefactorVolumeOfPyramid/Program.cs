using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, height;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            double volume = ((lenght * width) * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
