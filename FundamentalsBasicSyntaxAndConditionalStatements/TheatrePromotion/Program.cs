using System;

namespace _0._7TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (dayType)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18 || age >= 65 && age <= 122)
                    {
                        sum = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        sum = 18;
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18 || age >= 65 && age <= 122)
                    {
                        sum = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        sum = 20;
                    }
                    break;
                    case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        sum = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        sum = 12;
                    }
                    else if (age >= 65 && age <= 122)
                    {
                        sum = 10;
                    }
                    break;
                    
                default:
                    Console.WriteLine("Error!");
                    return;
            }
            if (sum > 0)
            {
            Console.WriteLine($"{sum}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
