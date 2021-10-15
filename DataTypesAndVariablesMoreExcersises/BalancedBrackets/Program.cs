using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());  // 40 - ( 41 - )
            int openBrackets = 0;
            int closeBrackets = 0;
            char previousChar = 'a';

            int nestedOpenedBrecketCount = 0;
            int nestedCloseBrecketCount = 0;
            bool isOpen = false;

            for (int i = 1; i <= num; i++)
            {
                string currentInput = Console.ReadLine();

                for (int j = 0; j < currentInput.Length; j++)
                {
                    char currentChar = currentInput[j];

                    if (currentChar == previousChar && previousChar == 40 && previousChar == 41)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }

                    if (currentChar == 40)
                    {
                        openBrackets++;
                        previousChar = currentChar;
                        isOpen = true;
                    }
                    else if (currentChar == 41)
                    {
                        closeBrackets++;
                        previousChar = currentChar;
                        isOpen = false;
                    }


                    previousChar = currentChar;
                }

            }
            if (isOpen)
            {
                Console.WriteLine("UNBALANCED");
            }
            else if (openBrackets != closeBrackets)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
