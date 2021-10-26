using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers  = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();
                string firstCommandElement = commands[0];
                int secondCommandElement = 0;
                int thirdCommandElement = 0;
                bool isNumber = int.TryParse(commands[1], out secondCommandElement);
                bool isNumber2 = false;

                if (commands.Count == 3)
                {
                    isNumber2 = int.TryParse(commands[2], out thirdCommandElement);
                }

                if (firstCommandElement == "Add" && isNumber == true)
                {
                    AddNewElement(ref numbers , secondCommandElement);
                }
                else if (firstCommandElement == "Remove" && isNumber == true)
                {
                    RemoveANumber(ref numbers , secondCommandElement);
                }
                else if (firstCommandElement == "RemoveAt" && isNumber == true)
                {
                    RemoveAtIndex(ref numbers , secondCommandElement);
                }
                else if (firstCommandElement == "Insert" && isNumber == true && isNumber2 == true)
                {
                    InsertNumberAtGivenIndex(ref numbers , secondCommandElement , thirdCommandElement);
                }
            }

            Console.WriteLine(string.Join(" " , numbers));
        }

        static void AddNewElement (ref List<int> numbers , int numberToAdd)
        {
            numbers.Add(numberToAdd);
        }

        static void RemoveANumber (ref List<int> numbers , int numberToRemove)
        {
            numbers.Remove(numberToRemove);
        }

        static void RemoveAtIndex (ref List<int> numbers , int indexToRemove)
        {
            numbers.RemoveAt(indexToRemove);
        }

        static void InsertNumberAtGivenIndex (ref List<int>  numbers, int numberToInsert , int indexToInsertAt)
        {
            numbers.Insert(indexToInsertAt , numberToInsert);
        }
    }
}
