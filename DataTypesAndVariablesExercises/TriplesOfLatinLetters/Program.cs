using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num ; i++)
            {
                for (int j = 0; j < num ; j++)
                {
                    for (int k = 0; k < num; k++)
                    { 
                        Console.WriteLine($"{(char)(i +97)}{(char)(j + 97)}{(char)(k + 97)}");
                    }
                }
            }
        }
    }
}
