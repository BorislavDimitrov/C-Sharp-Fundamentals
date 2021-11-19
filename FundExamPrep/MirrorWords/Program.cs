using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(\#|\@)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1");
            MatchCollection pairs = pattern.Matches(input);
            Dictionary<string, string> validPairs = new Dictionary<string, string>();

            foreach (Match pair in pairs)
            {
                string currFirstWord = pair.Groups["firstWord"].Value;
                string currSecondWord = pair.Groups["secondWord"].Value;
                string reversedSecondWord = new string(currSecondWord.Reverse().ToArray());

                if (currFirstWord == reversedSecondWord)
                {
                    validPairs.Add(currFirstWord , currSecondWord);
                }
            }

            if (pairs.Count > 0)
            {
                Console.WriteLine($"{pairs.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (validPairs.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
            
            int counter = 0;

            foreach (var pair in validPairs)
            {
                counter++;

                if (counter < validPairs.Count)
                {
                    Console.Write(pair.Key + " <=> " + pair.Value + ", ");
                }
                else
                {
                    Console.Write(pair.Key + " <=> " + pair.Value);
                }
            }
        }
    }
}
