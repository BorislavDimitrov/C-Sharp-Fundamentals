using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex patternDecrypt = new Regex(@"[sStTaArR]");
            Regex generalPattern = new Regex(@"[^\@\-\*\:]*@(?<name>[A-Za-z]+)[^\@\-\*\:]*:(?<population>[0-9]+)[^\@\-\*\:]*!(?<action>[A|D])![^\@\-\*\:]*->(?<soldiers>[0-9]+)[^\@\-\*\:]*");
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                var matches = patternDecrypt.Matches(input);
                int timesDecrypt = matches.Count;
                string decryptedText = GetDecryptedText(input, timesDecrypt).ToString();

                if (generalPattern.IsMatch(decryptedText))
                {
                    var currMatch = generalPattern.Match(decryptedText);

                    if (currMatch.Groups["action"].Value == "A")
                    {
                        attackedPlanets.Add(currMatch.Groups["name"].Value);
                    }
                    else
                    {
                        destroyedPlanets.Add(currMatch.Groups["name"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            attackedPlanets.Sort();

            for (int i = 0; i < attackedPlanets.Count; i++)
            {
                Console.WriteLine($"-> {attackedPlanets[i]}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
             destroyedPlanets.Sort();

            for (int j = 0; j < destroyedPlanets.Count; j++)
            {
                Console.WriteLine($"-> {destroyedPlanets[j]}");
            }
            
        }

        public static StringBuilder GetDecryptedText(string input, int timesDecrypt)
        {
            StringBuilder decryptedText = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int currentLetterNum = (int)input[i];
                char decryptedLetter = (char)(currentLetterNum - timesDecrypt);
                decryptedText.Append(decryptedLetter);
            }
            return decryptedText;
        }
    }
}
