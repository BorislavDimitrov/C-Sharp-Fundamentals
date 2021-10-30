using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToList();
            Console.WriteLine(string.Join(" \n" , words ));
        }
    }
}
