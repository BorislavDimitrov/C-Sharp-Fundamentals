using System;

namespace _Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string sign = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Calculations(sign, firstNum, secondNum);
        }

        static void Calculations(string sign , int firstNum , int secondNum) 
        {
            if (sign == "add")
            {
                Console.WriteLine(firstNum + secondNum);
            }
            else if (sign == "subtract")
            {
                Console.WriteLine(firstNum - secondNum);
            }
            else if (sign == "multiply")
            {
                Console.WriteLine(firstNum * secondNum);
            }
            else if (sign == "divide")
            {
                Console.WriteLine(firstNum / secondNum);
            }
        }
    }
}
