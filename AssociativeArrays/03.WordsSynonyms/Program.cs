using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordsSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            var synonymsDictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string currentWord = Console.ReadLine();
                string currentSynonym = Console.ReadLine();

                if (synonymsDictionary.ContainsKey(currentWord))
                {
                    synonymsDictionary[currentWord].Add(currentSynonym);
                }
                else
                {
                    synonymsDictionary.Add(currentWord , new List<string>());
                    synonymsDictionary[currentWord].Add(currentSynonym);
                }
            }

            foreach (var item in synonymsDictionary)
            {
                Console.WriteLine(item.Key +" - " + string.Join(", " , item.Value));
            }
        }
    }
}
