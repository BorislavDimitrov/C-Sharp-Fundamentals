using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.Replace('\\' , ' ' );
            text = text.Replace('.' , ' ');

            List<string> directory = text.Split().ToList();
            Console.WriteLine($"File name: {directory[directory.Count-2]}");
            Console.WriteLine($"File extension: {directory[directory.Count-1]}");
        }
    }
}
