using System;

namespace _09.PadwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvaliable = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsaberAmountNeeded = students * 1.00  + Math.Ceiling((students * 1.00 * 10 / 100));
            double lightsabersSum = lightsaberAmountNeeded * lightsaberPrice;

            double freeBelts = students * 1.00 / 6;
            double beltsAmountNeeded = Math.Ceiling(students - freeBelts);
            double beltsSum = beltsAmountNeeded * beltPrice;
            double robesSum = robePrice * students;

            double totalSum = robesSum + lightsabersSum + beltsSum;

            if (moneyAvaliable >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - moneyAvaliable:F2}lv more.");
            }
        }
    }
}
