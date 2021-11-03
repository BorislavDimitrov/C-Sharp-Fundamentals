using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ").ToList();


            for (int i = 0; i < usernames.Count; i++)
            {
                bool isValid = true;

                if (usernames[i].Length >= 3 && usernames[i].Length <= 16)
                {
                    for (int j = 0; j < usernames[i].Length; j++)
                    {
                        if (!char.IsDigit(usernames[i][j]) && !char.IsLetter(usernames[i][j]) && usernames[i][j] != '-' && usernames[i][j] != '_')
                        {
                            isValid = false;
                        }
                    }
                }
                else
                {
                    isValid = false;
                }
                

                if (isValid)
                {
                    Console.WriteLine(usernames[i]);
                }
            }

        }
    }
}
