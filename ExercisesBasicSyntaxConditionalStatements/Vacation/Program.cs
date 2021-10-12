using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            double businessTicketPrice = 0;

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    totalPrice = peopleNum * 8.45;
                }
                else if (groupType == "Business")
                {
                    businessTicketPrice = 10.90;
                    totalPrice = peopleNum * 10.90;
                }
                else if (groupType == "Regular")
                {
                    totalPrice = peopleNum * 15;
                }
            }
            else if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    totalPrice = peopleNum * 9.80;
                }
                else if (groupType == "Business")
                {
                    businessTicketPrice = 15.60;
                    totalPrice = peopleNum * 15.60;
                }
                else if (groupType == "Regular")
                {
                    totalPrice = peopleNum * 20;
                }
            }
            else if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    totalPrice = peopleNum * 10.46;
                }
                else if (groupType == "Business")
                {
                    businessTicketPrice = 16;
                    totalPrice = peopleNum * 16;
                }
                else if (groupType == "Regular")
                {
                    totalPrice = peopleNum * 22.50;
                }
            }

            if (groupType == "Students" && peopleNum >= 30)
            {
                totalPrice -= totalPrice * 15 / 100;
            }
            else if (groupType == "Business" && peopleNum >= 100)
            {
                totalPrice -= 10 * businessTicketPrice;
            }
            else if (groupType == "Regular" && (peopleNum >= 10 && peopleNum <= 20))
            {
                totalPrice -= totalPrice * 5 / 100;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
