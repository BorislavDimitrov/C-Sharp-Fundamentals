using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine().Split(", ").ToList();
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Count; i++)
            {
                while (text.Contains(bannedWords[i]))
                {
                    string replacemnt = new string( '*' , bannedWords[i].Length);
                    text = text.Replace(bannedWords[i] , replacemnt);
                }
            }
            Console.WriteLine(text);
        }
    }
}
