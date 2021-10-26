using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commandElements = input.Split().ToList();
                string firstElementText = commandElements[0];
                string secondElementText = string.Empty;
                int secondElementNumber = 0;
                int thirdElementNumber = 0;
                bool isSecondElementNumber = false;
                bool isThirdElementNumber = false;

                if (commandElements.Count == 2)
                {
                    isSecondElementNumber = int.TryParse(commandElements[1], out secondElementNumber);
                }

                if (commandElements.Count == 3)
                {
                    if (isSecondElementNumber = int.TryParse(commandElements[1], out secondElementNumber))
                    {

                    }
                    else
                    {
                        secondElementText = commandElements[1];
                    }

                    isThirdElementNumber = int.TryParse(commandElements[2], out thirdElementNumber);
                }

                if (firstElementText == "Add" && isSecondElementNumber == true)
                {
                    AddElement(numbers , secondElementNumber);
                }
                else if (firstElementText == "Insert" && isSecondElementNumber == true && isThirdElementNumber == true)
                {
                    InsertElementAtIndex(numbers , secondElementNumber , thirdElementNumber);
                }
                else if (firstElementText == "Remove" && isSecondElementNumber == true)
                {
                    RemoveElement(numbers , secondElementNumber);
                }
                else if (firstElementText == "Shift" && secondElementText == "left" && isThirdElementNumber == true)
                {
                    ShiftLeft(numbers , thirdElementNumber);
                }
                else if (firstElementText == "Shift" && secondElementText == "right" && isThirdElementNumber == true)
                {
                    ShiftRight(numbers , thirdElementNumber);
                }
                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void AddElement(List<int> numbers, int elemnent)
        {
            numbers.Add(elemnent);
        }

        static void InsertElementAtIndex (List<int> numbers , int element , int index)
        {
            if (index < 0 || index > numbers.Count - 1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, element);
            }
            
        }

        static void RemoveElement (List<int> numbers , int index)
        {
            if (index < 0 || index > numbers.Count - 1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(index);
            }
            
        }

        static void ShiftLeft (List<int> numbers , int count)
        {
            int firstElement = 0;
            for (int i = 0; i < count; i++)
            {
                firstElement = numbers[0];
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Count - 1] = firstElement;
            }
        }

        static void ShiftRight (List<int> numbers , int count)
        {
            int lastElement = 0;

            for (int i = 0; i < count; i++)
            {
                lastElement = numbers[numbers.Count - 1];
                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = lastElement;
            }
        }
    }
}
