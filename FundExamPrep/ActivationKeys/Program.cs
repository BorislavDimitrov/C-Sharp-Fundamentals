using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "Generate")
            {
                List<string> commandInfo = input.Split(">>>").ToList();
                string firstCommand = commandInfo[0];
                string substring = string.Empty;
                string upperOrLower = string.Empty;
                int startIndex = 0;
                int endIndex = 0;

                if (firstCommand == "Contains")
                {
                    substring = commandInfo[1];

                    if (text.Contains(substring))
                    {
                        Console.WriteLine($"{text} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (firstCommand == "Flip")
                {
                    upperOrLower = commandInfo[1];
                    startIndex = int.Parse(commandInfo[2]);
                    endIndex = int.Parse(commandInfo[3]);
                    string textToChange = string.Empty;

                    for (int i = startIndex ; i < endIndex; i++)
                    {
                        textToChange += text[i];
                    }

                    if (upperOrLower == "Lower")
                    {
                        text = text.Replace(textToChange , textToChange.ToLower());
                    }
                    else if (upperOrLower == "Upper")
                    {
                        text = text.Replace(textToChange , textToChange.ToUpper());
                    }

                    Console.WriteLine(text);
                }
                else if (firstCommand == "Slice")
                {
                    startIndex = int.Parse(commandInfo[1]);
                    endIndex = int.Parse(commandInfo[2]);
                    int count = endIndex - startIndex;

                    text = text.Remove(startIndex ,count );
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine($"Your activation key is: {text}");
        }
    }
}
