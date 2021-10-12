using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string word = string.Empty;
           
            for (int i = 1; i <= num; i++)
            {
                string input = Console.ReadLine();
                int length = input.Length;
                int digit = int.Parse(input[0].ToString());

                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    word += (char)32;
                    continue;
                }
              
                if (digit == 9 || digit == 8)
                {
                    offset += 1;
                }

                int letterIndex = (offset + length - 1) + 97;
                word += (char)letterIndex;

            }
            Console.WriteLine(word);
        }
    }
}
