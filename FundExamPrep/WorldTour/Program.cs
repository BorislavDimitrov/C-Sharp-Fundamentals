using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Travel")
            {
                List<string> commandInfo = input.Split(":").ToList();
                string firstCommand = commandInfo[0];
                int index = 0;
                int endIndex = 0;
                string newText = string.Empty;
                string oldText = string.Empty;

                if (firstCommand == "Add Stop")
                {
                    index = int.Parse(commandInfo[1]);
                    newText = commandInfo[2];

                    if (index >= 0 && index <= text.Length - 1)
                    {
                        text = text.Insert(index , newText);
                    }
                }
                else if(firstCommand == "Remove Stop")
                {
                    index = int.Parse(commandInfo[1]);
                    endIndex = int.Parse(commandInfo[2]);

                    if ((index >= 0 && index <= text.Length - 1) && (endIndex >=0 && endIndex <= text.Length - 1))
                    {
                        int diff = endIndex - index;
                        text = text.Remove(index, diff + 1);
                    }
                }
                else if (firstCommand == "Switch")
                {
                    oldText = commandInfo[1];
                    newText = commandInfo[2];

                    if (text.Contains(oldText))
                    {
                        text = text.Replace(oldText,newText);
                    }
                }
                Console.WriteLine(text);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
