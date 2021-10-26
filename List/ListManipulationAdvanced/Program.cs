using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;
            bool isChanged = false;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();
                string firstCommand = commands[0];
                int secondCommand = 0;
                int thirdCommand = 0;
                bool isSecondCommandNumber = false;
                bool isThirdCommandNumber = false;

                if (commands.Count >= 2)
                {
                    isSecondCommandNumber = int.TryParse(commands[1] , out secondCommand);
                }

                if (commands.Count == 3)
                {
                    isThirdCommandNumber = int.TryParse(commands[2] , out thirdCommand);
                }

                if (firstCommand == "Add" && isSecondCommandNumber == true)
                {
                    AddNewElement(ref numbers, secondCommand);
                    isChanged = true;
                }
                else if (firstCommand == "Remove" && isSecondCommandNumber == true)
                {
                    RemoveANumber(ref numbers, secondCommand);
                    isChanged = true;
                }
                else if (firstCommand == "RemoveAt" && isSecondCommandNumber == true)
                {
                    RemoveAtIndex(ref numbers, secondCommand);
                    isChanged = true;
                }
                else if (firstCommand == "Insert" && isSecondCommandNumber == true && isThirdCommandNumber == true)
                {
                    InsertNumberAtGivenIndex(ref numbers, secondCommand, thirdCommand);
                    isChanged = true;
                }

                if (firstCommand == "Contains" && isSecondCommandNumber == true)
                {
                    Console.WriteLine(DoesItContains(numbers , secondCommand));
                }
                else if (firstCommand == "PrintEven")
                {
                    PrintEvenNumbers(numbers);
                }
                else if (firstCommand == "PrintOdd")
                {
                    PrintOddNumber(numbers);
                }
                else if (firstCommand == "GetSum")
                {
                    Console.WriteLine(GetSum(numbers));
                }
                else if (firstCommand == "Filter" && isSecondCommandNumber== false && isThirdCommandNumber == true)
                {
                    FilteredNumbers(numbers, commands[1], thirdCommand);
                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static string DoesItContains (List<int> numbers , int element)
        {
            bool contains = false;
            string result = string.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == element)
                {
                    contains = true;
                    break;
                }
            }

            if (contains)
            {
                result = "Yes";
                return result;
            }
            else
            {
                result = "No such number";
                return result;
            }
        }

        static void PrintEvenNumbers (List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" " , evenNumbers));
        }

        static void PrintOddNumber (List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();

            oddNumbers = numbers.ToList();

            oddNumbers.RemoveAll(i => i % 2 == 0);
            Console.WriteLine(string.Join(" " , oddNumbers));
        }

        static int GetSum (List<int> numbers)
        {
            int sum = 0;

            sum = numbers.Sum();
            return sum;
        }

        static void FilteredNumbers (List<int> numbers , string condition , int number)
        {

            List<int> filteredNumbers = new List<int>();
            List<int> numbersAvoidRef = numbers.ToList();
            int listLenght = numbers.Count;

            for (int i = 0; i < listLenght; i++)
            {
                if (condition == "<")
                {
                    if (numbersAvoidRef[i] < number)
                    {
                        filteredNumbers.Add(numbersAvoidRef[i]);
                    }
                }
                else if (condition == "<=")
                {
                    if (numbersAvoidRef[i] <= number)
                    {
                        filteredNumbers.Add(numbersAvoidRef[i]);
                    }
                }
                else if (condition == ">")
                {
                    if (numbersAvoidRef[i] > number)
                    {
                        filteredNumbers.Add(numbersAvoidRef[i]);
                    }
                }
                else if (condition == ">=")
                {
                    if (numbersAvoidRef[i] >= number)
                    {
                        filteredNumbers.Add(numbersAvoidRef[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", filteredNumbers));
        }

        static void AddNewElement(ref List<int> numbers, int numberToAdd)
        {
            numbers.Add(numberToAdd);
        }

        static void RemoveANumber(ref List<int> numbers, int numberToRemove)
        {
            numbers.Remove(numberToRemove);
        }

        static void RemoveAtIndex(ref List<int> numbers, int indexToRemove)
        {
            numbers.RemoveAt(indexToRemove);
        }

        static void InsertNumberAtGivenIndex(ref List<int> numbers, int numberToInsert, int indexToInsertAt)
        {
            numbers.Insert(indexToInsertAt, numberToInsert);
        }
    }
}
