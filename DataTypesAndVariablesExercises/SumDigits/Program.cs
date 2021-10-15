using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int numLenght = num.ToString().Length;
            string currentNum = num.ToString();

            for (int i = 0; i < numLenght; i++)
            {
                int currentDigit = int.Parse(currentNum[i].ToString());
                sum += currentDigit;
            }
            Console.WriteLine(sum);
        }

    }
}
