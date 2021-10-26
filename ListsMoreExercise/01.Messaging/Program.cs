using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            string resultText = string.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                string currentElement = numbers[i].ToString();
                string tempText = string.Empty;
                int currentElementSum = SumOfElement(currentElement);
                int index = currentElementSum;

                if (currentElementSum <= text.Length - 1)
                {
                    resultText += text[index];
                }
                else if (currentElementSum > text.Length - 1)
                {
                    index = currentElementSum % text.Length;
                    resultText += text[index];
                }

                text = RemovingCharFromText(text , index);
            }
            Console.WriteLine(resultText);
        }

        static int SumOfElement(string currentElement)
        {
            int currentElementSum = 0;
            for (int j = 0; j < currentElement.Length; j++)
            {
                currentElementSum += int.Parse(currentElement[j].ToString());
            }
            return currentElementSum;
        }

        static string RemovingCharFromText (string text , int indexToRemove)
        {
            string reworkedText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (i != indexToRemove)
                {
                    reworkedText += text[i];
                }
            }
            return reworkedText;
        }
    }
}
