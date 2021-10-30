using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceBook = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                List<string> command = input.Split().ToList();
                string sign = string.Empty;

                if (command.Contains("->"))
                {
                    sign = " -> ";
                }
                else
                {
                    sign = " | ";
                }

                List<string> text = input.Split(new string[]{" | ", " -> "} , StringSplitOptions.RemoveEmptyEntries).ToList();
                string firstInfo = text[0];
                string secondInfo = text[1];

                if (sign == " | ")
                {
                    if (forceBook.ContainsKey(firstInfo))
                    {
                        if (!CheckIfUserExist(forceBook , secondInfo))
                        {
                            forceBook[firstInfo].Add(secondInfo);
                        }
                    }
                    else
                    {
                        forceBook.Add(firstInfo, new List<string>());
                        if (!CheckIfUserExist(forceBook , secondInfo))
                        {
                            forceBook[firstInfo].Add(secondInfo);
                        }
                        
                    }
                }
                else if (sign == " -> ")
                {
                    if (forceBook.ContainsKey(secondInfo))
                    {
                        if (CheckIfUserExist(forceBook, firstInfo))
                        {
                            UserChangeSide(forceBook, firstInfo, secondInfo);
                            Console.WriteLine($"{firstInfo} joins the {secondInfo} side!");
                        }
                        else
                        {
                            forceBook[secondInfo].Add(firstInfo);
                            Console.WriteLine($"{firstInfo} joins the {secondInfo} side!");
                        }
                    }
                    else
                    {
                        forceBook.Add(secondInfo , new List<string>());
                        if (CheckIfUserExist(forceBook , firstInfo))
                        {
                            UserChangeSide(forceBook, firstInfo, secondInfo);
                            Console.WriteLine($"{firstInfo} joins the {secondInfo} side!");
                        }
                        else
                        {
                            forceBook[secondInfo].Add(firstInfo);
                            Console.WriteLine($"{firstInfo} joins the {secondInfo} side!");
                        }
                        
                    }
                    
                }
            }

            forceBook = forceBook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key , y => y.Value);
            PrintSides(forceBook);
        }

        public static bool CheckIfUserExist (Dictionary<string , List<string>> forceBook , string forceUser)
        {
            bool userExist = false;

            foreach (var side in forceBook)
            {
                for (int i = 0; i < forceBook[side.Key].Count; i++)
                {
                    if (forceBook[side.Key][i] == forceUser)
                    {
                        userExist = true;
                        break;
                    }
                }
            }
            return userExist;
        }

        public static void UserChangeSide (Dictionary<string, List<string>> forceBook , string forceUser , string forceSide)
        {
            foreach (var side in forceBook)
            {
                for (int i = 0; i < forceBook[side.Key].Count; i++)
                {
                    if (forceBook[side.Key][i] == forceUser)
                    {
                        forceBook[side.Key].Remove(forceUser);
                        break;
                    }
                }
            }

            forceBook[forceSide].Add(forceUser);
        }

        public static void PrintSides (Dictionary<string , List<string>> forceBook)
        {
            foreach (var side in forceBook)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    List<string> currenUsersList = forceBook[side.Key].OrderBy(x => x).ToList();

                    for (int i = 0; i < currenUsersList.Count; i++)
                    {
                        Console.WriteLine($"! {currenUsersList[i]}");
                    }
                }
            }
        }
    }
}
