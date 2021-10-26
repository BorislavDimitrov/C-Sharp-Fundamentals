using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split().ToList();
                string firstCommandElement = command[0];
                int secondCommandElement = 0;
                int thirdCommandElement = 0;
                bool isSecondElementNum = int.TryParse(command[1] ,out secondCommandElement);
                bool isThirdElementNum = false;

                if (command.Count == 3)
                {
                    isThirdElementNum = int.TryParse(command[2] , out thirdCommandElement);
                }

                if (firstCommandElement == "Delete" && isSecondElementNum == true)
                {
                    DeleteElemnts(numbers , secondCommandElement);
                }
                else if (firstCommandElement == "Insert" && isSecondElementNum == true && isThirdElementNum == true)
                {
                    InsertElement(numbers , secondCommandElement , thirdCommandElement);
                }
            }
            Console.WriteLine(string.Join(" " , numbers));
        }

        static void DeleteElemnts (List<int> numbers , int elementToDelete)
        {
            numbers.RemoveAll(item => item == elementToDelete);
        }

        static void InsertElement(List<int> numbers , int element , int index)
        {
            numbers.Insert(index , element);
        }
    }
}
