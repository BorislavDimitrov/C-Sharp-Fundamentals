using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> virus = Console.ReadLine().Split().ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine() ) != "3:1")
            {
                List<string> command = input.Split().ToList();

                string firstCommand = command[0];
                int secondCommandElement = 0;
                int thirdCommandElement = 0;
                bool isSecondElementNum = int.TryParse(command[1] , out secondCommandElement);
                bool isThirdElementNum = int.TryParse(command[2] , out thirdCommandElement);

                if (firstCommand == "merge" && isSecondElementNum == true && isThirdElementNum == true)
                {
                    MergeElements(virus , secondCommandElement , thirdCommandElement);
                }
                else if (firstCommand == "divide" && isSecondElementNum == true && isThirdElementNum == true)
                {
                    DivideElement(virus , secondCommandElement , thirdCommandElement);
                }

               
            }
            Console.WriteLine(string.Join(" ", virus));
        }

        static void MergeElements (List<string> virus , int startIndex , int endIndex)
        {
            bool isStartIndexLessThanZero = false;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (i >= 0 && i <= virus.Count - 1)
                {
                    if (startIndex >= 0 && startIndex <= virus.Count - 1)
                    {
                        virus[startIndex] += virus[i];
                    }
                    else if (startIndex < 0)
                    {
                        isStartIndexLessThanZero = true;
                        if (i != 0)
                        {
                            virus[0] += virus[i];
                        }
                    }
                }
            }
            int removeStart = startIndex;
            int removeEnd = endIndex;
            int elemntsToRemove = 0;

            if (startIndex < 0 )
            {
                removeStart = 0;
            }

            if (endIndex > virus.Count - 1)
            {
                removeEnd = virus.Count - 1;
            }

            elemntsToRemove = removeEnd - removeStart;
            int removedElementCount = 0;

            if (removeStart <= virus.Count - 1 && removeEnd >= 0)
            {
               virus.RemoveRange(removeStart + 1, elemntsToRemove);
            }
            
        }

        static void DivideElement(List<string> virus , int index , int portions)
        {
            string sequenceToDivide = string.Empty;
            int indexDivide = 0;
            if (index >= 0 && index <= virus.Count - 1)
            {
                sequenceToDivide = virus[index];
                indexDivide = index;
            }
            else if (index < 0 )
            {
                sequenceToDivide = virus[0];
                indexDivide = 0;
            }
            if (sequenceToDivide.Length / portions >= 1)
            {
                int newSubsqencesLenght = sequenceToDivide.Length / portions;
                string subquenceToDivideSeparatedElements = string.Empty;

                for (int i = 0; i < sequenceToDivide.Length; i++)
                {
                    if (i < sequenceToDivide.Length - 1)
                    {
                        subquenceToDivideSeparatedElements += sequenceToDivide[i] + " ";
                    }
                    else
                    {
                        subquenceToDivideSeparatedElements += sequenceToDivide[i];
                    }

                }

                List<string> elementsToDivide = subquenceToDivideSeparatedElements.Split().ToList();
                virus.RemoveAt(indexDivide);
                for (int i = 1; i <= portions; i++)
                {
                    string currentNewSubquence = string.Empty;

                    for (int j = newSubsqencesLenght; j > 0; j--)
                    {

                        if (sequenceToDivide.Length % portions != 0 && i == 1)
                        {
                            int biggestSeq = sequenceToDivide.Length % portions;
                            biggestSeq += sequenceToDivide.Length / portions;
                            for (int k = biggestSeq; k > 0; k--)
                            {
                                currentNewSubquence += elementsToDivide[elementsToDivide.Count - k];
                                elementsToDivide.RemoveAt(elementsToDivide.Count - k);
                            }
                            break;
                        }

                        currentNewSubquence += elementsToDivide[elementsToDivide.Count - j];
                        elementsToDivide.RemoveAt(elementsToDivide.Count - j);
                    }

                    virus.Insert(indexDivide, currentNewSubquence);
                }
           
                
            }
            
        }
    }
}
