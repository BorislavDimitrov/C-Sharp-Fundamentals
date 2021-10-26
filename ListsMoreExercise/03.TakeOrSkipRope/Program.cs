using System;
using System.Collections.Generic;

namespace _03.TakeOrSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> numbers = GetOnlyNumbers(text);
            List<char> nonNumbers = GetOnlyNonNumbers(text);
            List<int> takeList = TakeOddIndexes(numbers);
            List<int> skipList = TakeEvenIndexes(numbers);
            string result = DecryptedText(nonNumbers , takeList , skipList);
            Console.WriteLine(result);
        }

        static List<int> GetOnlyNumbers (string text)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    int currentNum = int.Parse(text[i].ToString());
                    numbers.Add(currentNum);
                }
            }
            return numbers;
        }

        static List<char> GetOnlyNonNumbers(string text)
        {
            List<char> nonNumbers = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if ((char)text[i] < 47 || (char)text[i] > 57)
                {
                    nonNumbers.Add(text[i]);
                }
            }

            return nonNumbers;
        }

        static List<int> TakeOddIndexes (List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();

            for (int i = 1; i <= numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(numbers[i - 1]);
                }
            }
            return oddNumbers;
        }

        static List<int> TakeEvenIndexes (List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 1; i <= numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(numbers[i - 1]);
                }
            }
            return evenNumbers;
        }

        static string DecryptedText (List<char> nonNumbers , List<int> takeList , List<int> skipList)
        {
            string result = string.Empty;

            for (int i = 0; i < takeList.Count; i++)
            {
                int currentElementsToAdd = takeList[i];

                for (int j = 0; j < currentElementsToAdd; j++)
                {
                    if (nonNumbers.Count == 0)
                    {
                        break;
                    }
                    result += nonNumbers[0];
                    nonNumbers.RemoveAt(0);
                }

                for (int k = 0; k < skipList[i]; k++)
                {
                    if (nonNumbers.Count == 0)
                    {
                        break;
                    }
                    nonNumbers.RemoveAt(0);
                }
            }
            return result;
        }
    }

}
