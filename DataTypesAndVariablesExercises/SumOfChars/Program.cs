using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                sum += (int)currentChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
