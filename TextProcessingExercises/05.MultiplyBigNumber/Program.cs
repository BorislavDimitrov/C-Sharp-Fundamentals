using System;
using System.Collections.Generic;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            if (num2 == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int decimalReminder = 0;
            int currentMultiplication = 0;

            for (int i = bigNumber.Length-1; i >= 0; i--)
            {
                int currentNumber = int.Parse(bigNumber[i].ToString());
                currentMultiplication = currentNumber * num2;
                currentMultiplication += decimalReminder;
                result.Add(currentMultiplication % 10);
                decimalReminder = currentMultiplication / 10;
            }

            if (decimalReminder > 0)
            {
                result.Add(decimalReminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
