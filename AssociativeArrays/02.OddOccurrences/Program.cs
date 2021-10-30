using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            var dictionary = new Dictionary<string , int>();

            for (int i = 0; i < words.Count; i++)
            {
                string currentKey = words[i].ToLower();
                if (dictionary.ContainsKey(currentKey))
                {
                    dictionary[currentKey]++;
                }
                else
                {
                    dictionary.Add(currentKey , 1);
                }
            }

            foreach (var key in dictionary)
            {
                if (key.Value % 2 != 0)
                {
                    Console.Write(key.Key + " ");
                }
            }
        }
    }
}
