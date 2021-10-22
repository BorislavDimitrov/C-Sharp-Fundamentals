using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                List<string> commandInfo = input.Split().ToList();
                string firstCommand = commandInfo[0];
                int index = 0;
                int lenght = 0;
                string oldSubstring = string.Empty;
                string newSusbstring = string.Empty;

                if (firstCommand == "TakeOdd")
                {
                    string newPass = string.Empty;

                    for (int i = 1; i < text.Length; i += 2)
                    {
                        newPass += text[i];
                    }

                    text = newPass;
                    Console.WriteLine(text);

                }
                else if (firstCommand == "Cut")
                {
                    index = int.Parse(commandInfo[1]);
                    lenght = int.Parse(commandInfo[2]);
                    text = text.Remove(index , lenght);
                    Console.WriteLine(text);
                }
                else if (firstCommand == "Substitute")
                {
                    oldSubstring = commandInfo[1];
                    newSusbstring = commandInfo[2];

                    if (text.Contains(oldSubstring))
                    {
                        text = text.Replace(oldSubstring, newSusbstring);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {text}");
        }
    }
}
