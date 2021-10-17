using System;

namespace _GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            if (inputType == "string")
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                Console.WriteLine(StringGreaterValue(firstValue , secondValue));
            }
            else if (inputType == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                Console.WriteLine(IntegerGreaterValue(firstValue , secondValue));
            }
            else if (inputType == "char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                Console.WriteLine(CharGreaterValue(firstValue , secondValue));
            }
        }
        static int IntegerGreaterValue (int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

        static char CharGreaterValue (char firstValue , char secondValue) 
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

        static string StringGreaterValue(string firstValue , string secondValue) 
        {
            int isGreater = firstValue.CompareTo(secondValue);

            if (isGreater == 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
