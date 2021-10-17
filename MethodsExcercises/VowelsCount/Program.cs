using System;

namespace _VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine( NumberOfVowels(input));
        }

        static int NumberOfVowels (string input)
        {
            int vowelsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A' || input[i] == 'e' || input[i] == 'E' || input[i] == 'i' || input[i] == 'I' || input[i] == 'o' || input[i] == 'O' ||
                    input[i] == 'u' || input[i] == 'U')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
