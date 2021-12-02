using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Decode")
            {
                List<string> commandInfo = input.Split("|").ToList();
                string firstCommand = commandInfo[0];
                int numbersCommand = 0;
                string textToInsert = string.Empty;
                string textToReplace = string.Empty;
                string replacementText = string.Empty;

                if (firstCommand == "Move")
                {
                    numbersCommand = int.Parse(commandInfo[1]);
                    int counter = 0;

                    for (int i = 0; i < sb.Length; i++)
                    {
                        sb.Append(sb[i]);
                        counter++;

                        if (counter == numbersCommand)
                        {
                            break;
                        }
                    }

                    sb.Remove(0 , numbersCommand);
                }
                else if (firstCommand == "Insert")
                {
                    numbersCommand = int.Parse(commandInfo[1]);
                    textToInsert = commandInfo[2];
                    sb = sb.Insert(numbersCommand , textToInsert);
                }
                else if (firstCommand == "ChangeAll")
                {
                    textToReplace = commandInfo[1];
                    replacementText = commandInfo[2];

                    sb.Replace(textToReplace , replacementText);
                }
            }
            Console.WriteLine($"The decrypted message is: {sb}");
        }
    }
}
