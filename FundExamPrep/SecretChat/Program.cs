using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                List<string> commandInfo = input.Split(":|:").ToList();
                string firstCommand = commandInfo[0];
                int index = 0;
                string substring = string.Empty;
                string replacementText = string.Empty;

                if (firstCommand == "InsertSpace")
                {
                    index = int.Parse(commandInfo[1]);
                    text = text.Insert(index , " ");
                    Console.WriteLine(text);
                }
                else if (firstCommand == "Reverse")
                {
                    substring = commandInfo[1];

                    if (text.Contains(substring))
                    {
                        int startIndex = text.IndexOf(substring);
                        text = text.Remove(startIndex , substring.Length);
                        string reversedSubstring = new string(substring.Reverse().ToArray());
                        text += reversedSubstring;
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (firstCommand == "ChangeAll")
                {
                    substring = commandInfo[1];
                    replacementText = commandInfo[2];
                    text = text.Replace(substring , replacementText);
                    Console.WriteLine(text);
                }
            }

            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
