﻿using System;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string reversedWord = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedWord += input[i];
                }
                Console.WriteLine(input + " = " + reversedWord);
            }
        }
    }
}
