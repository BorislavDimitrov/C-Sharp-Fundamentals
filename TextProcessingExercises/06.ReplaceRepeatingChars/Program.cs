using System;
using System.Collections.Generic;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int counter = 1;
            char prevChar = text[0];
            

            for (int i = 1; i < text.Length; i++)
            {
                char currChar = (char)text[i];

                if (currChar == prevChar)
                {
                    prevChar = currChar;
                    counter++;
                }
                else
                {
                    sb.Append(prevChar);
                    prevChar = currChar;
                }
                
            }
            sb.Append(text[text.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}
