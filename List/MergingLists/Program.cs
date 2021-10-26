using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListElements = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> seconsListElements = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultList = new List<int>();
            int leftElements = 0;
            bool isLenghtDifferent = false;
            int firstListLenght = firstListElements.Count;
            int secondListLenght = seconsListElements.Count;

            if (firstListElements.Count != seconsListElements.Count)
            {
                isLenghtDifferent = true;
                leftElements = Math.Abs(firstListElements.Count - seconsListElements.Count);
            }
            int oddEvenNum = 1;

            while (resultList.Count != (firstListLenght + secondListLenght))
            {
                if (firstListLenght > secondListLenght && seconsListElements.Count == 0)
                {
                    resultList.AddRange(firstListElements);
                    break;
                }
                else if (secondListLenght > firstListLenght && firstListElements.Count == 0)
                {
                    resultList.AddRange(seconsListElements);
                    break;
                }

                if (oddEvenNum % 2 != 0)
                {
                    resultList.Add(firstListElements[0]);
                    firstListElements.RemoveAt(0);
                }
                else if (oddEvenNum % 2 == 0)
                {
                    resultList.Add(seconsListElements[0]);
                    seconsListElements.RemoveAt(0);
                }
                oddEvenNum++;
            }

            Console.WriteLine(string.Join(" " , resultList));
        }

      
    }
}
