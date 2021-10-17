using System;

namespace _CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharsBetweenTwoChars(firstChar, secondChar);
        }

        static void CharsBetweenTwoChars (char firstChar , int secondChar)
        {
            if (firstChar > secondChar)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            
        }
    }
}
