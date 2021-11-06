using System;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int firstCharCode = (int)firstChar;
            int secondCharCode = (int)secondChar;
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (((int)text[i] > firstCharCode && (int)text[i] < secondCharCode ) || ((int)text[i] > secondCharCode && (int)text[i] < firstCharCode))
                {
                    sum += (int)text[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
