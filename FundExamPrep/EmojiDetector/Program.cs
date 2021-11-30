using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _14.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex numbersPattern = new Regex(@"\d");
            BigInteger threshold = 1;
            MatchCollection numbers = numbersPattern.Matches(input);
            
            foreach (Match number in numbers)
            {
                threshold *= int.Parse(number.Value);
            }

            Regex emojiPattern = new Regex(@"([:]{2}|[*]{2})(?<emoji>[A-Z]{1}[a-z]{2,})\1");
            MatchCollection emojis = emojiPattern.Matches(input);
            List<string> coolEmojis = new List<string>();

            foreach (Match emoji in emojis)
            {
                BigInteger coolnessCount = 0;

                for (int i = 0; i < emoji.Groups["emoji"].Value.Length; i++)
                {
                    coolnessCount += (int)emoji.Groups["emoji"].Value[i];
                }

                if (coolnessCount >= threshold)
                {
                    coolEmojis.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n" , coolEmojis));
        }
    }
}
