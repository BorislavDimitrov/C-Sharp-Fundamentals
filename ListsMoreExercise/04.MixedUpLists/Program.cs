using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            int firstNumRange = 0;
            int secondNumRange = 0;

            if (firstList.Count > secondList.Count)
            {
                firstNumRange = firstList[firstList.Count - 2];
                secondNumRange = firstList[firstList.Count- 1];
                firstList.RemoveAt(secondList.Count - 1);
                firstList.RemoveAt(secondList.Count - 1);
            }
            else if (secondList.Count > firstList.Count)
            {
                firstNumRange = secondList[0];
                secondNumRange = secondList[1];
                secondList.RemoveAt(0);
                secondList.RemoveAt(0);
            }

            int smallerNumRange = SmallerNumber(firstNumRange, secondNumRange);
            int biggerNumRange = BiggerNumber(firstNumRange, secondNumRange);

            List<int> mixedList = MixedList(firstList, secondList);
            List<int> result = new List<int>();

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > smallerNumRange && mixedList[i] < biggerNumRange)
                {
                    result.Add(mixedList[i]);
                }
            }

            result = result.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" " , result));
        }

        static List<int> MixedList (List<int> firstList , List<int> secondList)
        {
            List<int> mixedList = new List<int>();

            for (int i = 0; i < secondList.Count; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[secondList.Count - 1 - i]);
            }

            return mixedList;
        }

        static int SmallerNumber (int firstNum , int secondNum)
        {
            int smallerNum = 0;

            if (firstNum > secondNum)
            {
                smallerNum = secondNum;
            }
            else
            {
                smallerNum = firstNum;
            }

            return smallerNum;
        }

        static int BiggerNumber (int firstNum , int secondNum)
        {
            int biggerNum = 0;

            if (firstNum > secondNum)
            {
                biggerNum = firstNum;
            }
            else
            {
                biggerNum = secondNum;
            }

            return biggerNum;
        }
    }
}
