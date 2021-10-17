using System;

namespace _RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            RepeatStrings(n , text);
        }

        static void RepeatStrings(int n , string text) 
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(text);
            }
        }
    }
}
