using System;

namespace _Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string productType = Console.ReadLine();
            int productQuanity = int.Parse(Console.ReadLine());
            TotalSum(productType , productQuanity);
        }

        static void TotalSum(string productType, int productQuanity) 
        {
            double sum = 0;
            if (productType == "coffee")
            {
                sum += productQuanity * 1.50;
            }
            else if(productType == "water")
            {
                sum += productQuanity * 1.00;
            }
            else if (productType == "coke")
            {
                sum += productQuanity * 1.40;
            }
            else if (productType == "snacks")
            {
                sum += productQuanity * 2.00;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
