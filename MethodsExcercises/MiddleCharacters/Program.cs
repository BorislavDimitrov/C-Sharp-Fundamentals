using System;

namespace _MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(MiddleCharacters(input));
        }

        static bool CheckEvenOrOdd (string input)
        {
            bool isEven = false;
            if (input.Length % 2 == 0)
            {
                isEven = true;
            }
            return isEven;
        }

        static string MiddleCharacters (string input)
        {
            string text = string.Empty;
            if (CheckEvenOrOdd(input) == false)
            {
                text += input[input.Length / 2];
            }
            else
            {
                for (int i = (input.Length / 2) - 1; i < (input.Length / 2) + 1; i++)
                {
                    text += input[i];
                }
            }

            return text;
        }
    }
}
