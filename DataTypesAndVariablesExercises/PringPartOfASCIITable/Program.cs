using System;

namespace _05.PringPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingLetter = int.Parse(Console.ReadLine());
            int finishingLetter = int.Parse(Console.ReadLine());

            for (int i = startingLetter; i <= finishingLetter; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
