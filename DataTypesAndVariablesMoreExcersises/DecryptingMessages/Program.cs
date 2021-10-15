using System;

namespace _05.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string text = string.Empty;

            for (int i = 1; i <= lines; i++)
            {
                char currentLetter = char.Parse(Console.ReadLine());

                text += (char)(currentLetter + key);
            }
            Console.WriteLine(text);
        }
    }
}
