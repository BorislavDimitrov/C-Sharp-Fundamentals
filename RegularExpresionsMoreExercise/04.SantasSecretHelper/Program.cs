using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04.SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> goodKidNames = new List<string>();
            string input = string.Empty;
            Regex pattern = new Regex(@"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*!(?<behavior>[G|N])![^\@\-\!\:\>]*");

            while ((input = Console.ReadLine())!= "end")
            {
                string decryptedText = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    char currChar = input[i];
                    char decryptedChar = (char)((int)(currChar - key));
                    decryptedText += decryptedChar;
                }

                if (pattern.IsMatch(decryptedText))
                {
                    Match match = pattern.Match(decryptedText);

                    if (match.Groups["behavior"].Value == "G")
                    {
                        goodKidNames.Add(match.Groups["name"].Value);
                    }
                }               
            }

            Console.WriteLine(string.Join("\n" , goodKidNames));
        }
    }
}
