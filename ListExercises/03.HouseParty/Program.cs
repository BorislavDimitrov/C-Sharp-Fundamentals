using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                List<string> commandElements = command.Split().ToList();
                string guestName = commandElements[0];

                if (commandElements.Count == 3)
                {
                    if (guestList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(guestName);
                    }
                }
                else if (commandElements.Count == 4)
                {
                    if (guestList.Contains(guestName))
                    {
                        guestList.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guestList.Count; i++)
            {
                Console.Write(guestList[i]);
                Console.WriteLine();
            }
        }
    }
}
