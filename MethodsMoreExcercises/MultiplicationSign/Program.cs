using System;

namespace _MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            ResultOfThreeNumbers(firstNumber, secondNumber, thirdNumber);

        }

        static void ResultOfThreeNumbers (int num1 , int num2 , int num3)
        {
            int[] numbers = new int[3];
            numbers[0] = num1;
            numbers[1] = num2;
            numbers[2] = num3;
            int negativeCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeCounter++;
                }
            }

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else if (negativeCounter == 3)
            {
                Console.WriteLine("negative");
            }
            else if (negativeCounter == 2)
            {
                Console.WriteLine("positive");
            }
            else if (negativeCounter == 1)
            {
                Console.WriteLine("negative");
            }
            else if (negativeCounter == 0)
            {
                Console.WriteLine("positive");
            }
        }
    }
}
