using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex capitalLettersPattern = new Regex(@"([\#|\$|\%|\*|\&])(?<capitalLetters>[A-Z]+)(\1)");
            Regex lenghtPatters = new Regex(@"(?<capitalLetter>[0-9]{2}):(?<lenght>[0-9]{2})");
            List<string> input = Console.ReadLine().Split("|").ToList();

            Match capitalLetters = capitalLettersPattern.Match(input[0]);
            MatchCollection lenght = lenghtPatters.Matches(input[1]);

            List<string> capitalLettersList = new List<string>();
            capitalLettersList.Add(capitalLetters.Groups["capitalLetters"].Value.ToString());

            for (int i = 0; i < capitalLettersList[0].Length; i++)
            {
                char currentCapitalLetter = char.Parse(capitalLettersList[0][i].ToString());
                int currentWordLenght = 0;

                foreach (Match match in lenght)
                {
                    if ((int)currentCapitalLetter == int.Parse(match.Groups["capitalLetter"].Value))
                    {
                        currentWordLenght = int.Parse(match.Groups["lenght"].Value);
                    }
                }

                List<string> wordsList = input[2].Split().ToList();

                for (int j = 0; j < wordsList.Count; j++)
                {
                    if (currentCapitalLetter == wordsList[j][0] && wordsList[j].Length == currentWordLenght + 1)
                    {
                        Console.WriteLine(wordsList[j]);
                    }
                }
            }
        }
    }
}