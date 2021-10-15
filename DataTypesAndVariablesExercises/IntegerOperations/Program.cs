using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int plus = firstNum + secondNum;
            int divide = plus / thirdNum;
            int multiply = divide * fourthNum;
            Console.WriteLine(multiply);
        }
    }
}
