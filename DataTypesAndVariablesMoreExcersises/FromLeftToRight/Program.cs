using System;
using System.Numerics;
namespace _02.FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            
            for (int i = 1; i <= num; i++)
            {
                BigInteger sum = 0;
                string currentNumbers = Console.ReadLine();
                string firstNum = string.Empty;
                string secondNum = string.Empty;
                bool isSpace = false;

                for (int j = 0; j < currentNumbers.Length; j++)
                {
                    char index = currentNumbers[j];

                    if (index == 32)
                    {
                        isSpace = true;
                        continue;
                    }

                    if (!isSpace)
                    {
                        firstNum += index;
                    }
                    else
                    {
                        secondNum += index;
                    }
                }

                BigInteger leftNum = BigInteger.Parse(firstNum);
                BigInteger rightNum = BigInteger.Parse(secondNum);

                if (leftNum > rightNum)
                {
                    while (leftNum != 0)
                    {
                        sum += leftNum % 10;
                        leftNum /= 10;
                    }
                }
                else
                {
                    while (rightNum !=0 )
                    {
                        sum += rightNum % 10;
                        rightNum /= 10;
                    }
                }

                Console.WriteLine(BigInteger.Abs(sum));
            }
            
        }
    }
}