using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            var lettersDictionary = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (var letter in word)
                {
                    if (lettersDictionary.ContainsKey(letter))
                    {
                        lettersDictionary[letter]++;
                    }
                    else
                    {
                        lettersDictionary.Add(letter , 1);
                    }
                }
            }

            foreach (var letter in lettersDictionary)
            {
                Console.WriteLine(letter.Key + " -> " + letter.Value);
            }
        }
    }
}
