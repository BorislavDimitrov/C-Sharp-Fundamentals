using System;
using System.Linq;

namespace _MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sequanceNums = new int[numbers.Length];

            int previousElemnt = numbers[numbers.Length - 1];
            int previousCounter = 0;
            int currentCounter = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                
                if (previousElemnt == numbers[i])
                {
                    currentCounter++;
                    if (currentCounter >= previousCounter)
                    {
                        previousCounter = currentCounter;
                        sequanceNums = new int[currentCounter];
                        for (int j = 0; j < previousCounter ; j++)
                        {
                            sequanceNums[j] = numbers[i];
                            
                        }
                    }
                }
                else
                {
                    currentCounter = 1;
                }
                previousElemnt = numbers[i];
            }
            Console.WriteLine(String.Join(" " , sequanceNums));
        }
    }
}
