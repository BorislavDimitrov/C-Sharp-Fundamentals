using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine().Split(new char[2] {',' , ' '} , StringSplitOptions.RemoveEmptyEntries).ToList();
            Regex generalPattern = new Regex(@"[\@]{6,10}|[\#]{6,10}|[\$]{6,10}|[\^]{6,10}");

            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].Length == 20)
                {
                    string leftSide = string.Empty;
                    string rightSide = string.Empty;

                    for (int j = 0; j < 20; j++)
                    {
                        if (j < 10)
                        {
                            leftSide += tickets[i][j];
                        }
                        else
                        {
                            rightSide += tickets[i][j];
                        }
                    }
                    string checkedLeftSide = string.Empty;
                    string chechedRightSide = string.Empty;

                    bool leftIsMatch = false;
                    bool rightIsMatch = false;

                    if (generalPattern.IsMatch(leftSide))
                    {
                        leftIsMatch = true;
                        checkedLeftSide = generalPattern.Match(leftSide).ToString();
                    }

                    if (generalPattern.IsMatch(rightSide))
                    {
                        rightIsMatch = true;
                        chechedRightSide = generalPattern.Match(rightSide).ToString();
                    }


                    if (leftIsMatch && rightIsMatch)
                    {

                        if (checkedLeftSide[0] == chechedRightSide[0])
                        {
                            char symbol = chechedRightSide[0];

                            if (chechedRightSide.Length == 10 && checkedLeftSide.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - 10{symbol} Jackpot!");
                            }
                            else if (checkedLeftSide.Length > chechedRightSide.Length)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {chechedRightSide.Length}{symbol}");
                            }
                            else 
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {checkedLeftSide.Length}{symbol}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"invalid ticket");
                }
            }

        }
    }
}
