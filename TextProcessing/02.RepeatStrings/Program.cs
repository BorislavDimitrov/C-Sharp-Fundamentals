using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.Write(words[i]);
                }
            }
        }
    }
}
