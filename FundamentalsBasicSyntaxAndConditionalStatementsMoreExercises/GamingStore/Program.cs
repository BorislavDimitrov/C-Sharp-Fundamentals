using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double totalSpentMoney = 0;

            while (input != "Game Time")
            {
                string currentGameName = input;

                if (currentGameName != "OutFall 4" && currentGameName != "CS: OG" && currentGameName != "Zplinter Zell" && currentGameName != "Honored 2"
                    && currentGameName != "RoverWatch" && currentGameName != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }
                else
                {

                    if (currentGameName == "OutFall 4" && balance >= 39.99)
                    {
                        balance -= 39.99;
                        totalSpentMoney += 39.99;
                        Console.WriteLine($"Bought {currentGameName}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }

                    }
                    else if (currentGameName == "CS: OG" && balance >= 15.99)
                    {
                        balance -= 15.99;
                        totalSpentMoney += 15.99;
                        Console.WriteLine($"Bought {currentGameName}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else if (currentGameName == "Zplinter Zell" && balance >= 19.99)
                    {
                        balance -= 19.99;
                        totalSpentMoney += 19.99;
                        Console.WriteLine($"Bought {currentGameName}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else if (currentGameName == "Honored 2" && balance >= 59.99)
                    {
                        balance -= 59.99;
                        totalSpentMoney += 59.99;
                        Console.WriteLine($"Bought {currentGameName}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else if (currentGameName == "RoverWatch" && balance >= 29.99)
                    {
                        balance -= 29.99;
                        totalSpentMoney += 29.99;
                        Console.WriteLine($"Bought {currentGameName}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else if (currentGameName == "RoverWatch Origins Edition" && balance >= 39.99)
                    {
                        balance -= 39.99;
                        totalSpentMoney += 39.99;
                        Console.WriteLine($"Bought {currentGameName}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    input = Console.ReadLine();
                }

                if (input == "Game Time")
                {
                    Console.Write($"Total spent: ${totalSpentMoney:F2}. ");
                    Console.WriteLine($"Remaining: ${balance:F2}");
                }
            }
        }
    }
}
