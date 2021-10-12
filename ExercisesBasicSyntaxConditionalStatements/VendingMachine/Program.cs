using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double moneyInserted = 0;
            while (input != "Start")
            {
                double currentMoneyInserted = double.Parse(input);

                if (currentMoneyInserted == 0.1 || currentMoneyInserted == 0.2 || currentMoneyInserted == 0.5 || currentMoneyInserted == 1.0 || currentMoneyInserted == 2.0)
                {
                    moneyInserted += currentMoneyInserted;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentMoneyInserted}");
                }

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;
            
            while (secondInput != "End")
            {
                string productType = secondInput;

                if (productType == "Nuts" || productType == "Water" || productType == "Crisps" || productType == "Soda" || productType == "Coke")
                {
                    if (productType == "Nuts" && moneyInserted >= nutsPrice)
                    {
                        Console.WriteLine($"Purchased nuts");
                        moneyInserted -= nutsPrice;
                    }
                    else if (productType == "Water" && moneyInserted >= waterPrice)
                    {
                        Console.WriteLine($"Purchased water");
                        moneyInserted -= waterPrice;
                    }
                    else if (productType == "Crisps" && moneyInserted >= crispPrice)
                    {
                        Console.WriteLine($"Purchased crisps");
                        moneyInserted -= crispPrice;
                    }
                    else if (productType == "Soda" && moneyInserted >= sodaPrice)
                    {
                        Console.WriteLine($"Purchased soda");
                        moneyInserted -= sodaPrice;
                    }
                    else if (productType == "Coke" && moneyInserted >= cokePrice)
                    {
                        Console.WriteLine($"Purchased coke");
                        moneyInserted -= cokePrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                secondInput = Console.ReadLine();
            }

            if (secondInput == "End")
            {
                Console.WriteLine($"Change: {moneyInserted:F2}");
            }
        }
    }
}
