using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Console.WriteLine(CalculateChars(words[0] , words[1]));
        }

        public static int CalculateChars (string word1 , string word2)
        {
            int sum = 0;
            int length = 0;
            bool isWord1Len = false;
            bool isWord2Len = false;
            bool isWordsLenEven = false;

            if (word1.Length > word2.Length)
            {
                length = word2.Length;
                isWord1Len = true;
            }
            else if (word2.Length > word1.Length)
            {
                length = word1.Length;
                isWord2Len = true;
            }
            else if (word1.Length == word2.Length)
            {
                length = word1.Length;
            }

            for (int i = 0; i < length; i++)
            {
                sum += (int)(word1[i]) * (int)word2[i];
            }

            if (isWord1Len)
            {
                for (int i = length; i < word1.Length; i++)
                {
                    sum += (int)word1[i];
                }
            }
            else if (isWord2Len)
            {
                for (int i = length; i < word2.Length; i++)
                {
                    sum += (int)word2[i];
                }
            }
           
            return sum;
        }
    }
}
