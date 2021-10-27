using System;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                int randomInex = rnd.Next(i, words.Length - 1);
                words[i] = words[randomInex];
                words[randomInex] = temp;
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
