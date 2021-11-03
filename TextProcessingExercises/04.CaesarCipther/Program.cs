using System;
using System.Text;

namespace _04.CaesarCipther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int currCharNum = (int)currentChar + 3;
                char encryptedChar = (char)currCharNum;
                encryptedText.Append(encryptedChar);
            }
            Console.WriteLine(encryptedText);
        }
    }
}
