using System;
using System.Linq;
using System.Text;

namespace _ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandElements = command.Split().ToArray();
                int numCommand = 0;
                bool isElementNum = int.TryParse(commandElements[1], out numCommand);

                if (commandElements[0] == "exchange" && isElementNum == true)
                {
                    Exchange(ref numbers, numCommand);
                    
                }

                if (commandElements[0] == "max" && commandElements[1] == "odd")
                {
                    MaxOddEven(numbers , commandElements[1]);
                }
                else if (commandElements[0] == "max" && commandElements[1] == "even")
                {
                    MaxOddEven(numbers , commandElements[1]);
                }

                if (commandElements[0] == "min" && commandElements[1] == "odd")
                {
                    MinOddEven(numbers, commandElements[1]);
                }
                else if (commandElements[0] == "min" && commandElements[1] == "even")
                {
                    MinOddEven(numbers , commandElements[1]);
                }
                

                if (commandElements[0] == "first" && isElementNum == true && commandElements[2] == "odd")
                {
                    FirstOddsEvens(numbers , numCommand , commandElements[2]);
                }
                else if (commandElements[0] == "first" && isElementNum == true && commandElements[2] == "even")
                {
                    FirstOddsEvens(numbers , numCommand , commandElements[2]);
                }

                if (commandElements[0] == "last" && isElementNum == true && commandElements[2] == "odd")
                {
                    FirstOddsEvens(numbers, numCommand, commandElements[2]);
                }
                else if (commandElements[0] == "last" && isElementNum == true && commandElements[2] == "even")
                {
                    FirstOddsEvens(numbers, numCommand, commandElements[2]);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void Exchange(ref int[] numbers , int index )
        {
            
            StringBuilder elementsBefore = new StringBuilder();
            StringBuilder elementsAfter = new StringBuilder();
            bool isValid = true;
            if (index < 0 || index > numbers.Length - 1)
            {
                Console.WriteLine("Invalid index");
                isValid = false;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i <= index)
                    {
                        elementsBefore.Append(numbers[i] + " ");
                    }
                    else
                    {
                        elementsAfter.Append(numbers[i] + " ");
                    }
                }
            }

            if (isValid)
            {
                string finalArray = elementsAfter.ToString() + elementsBefore.ToString();
                numbers = finalArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            
        }

        static void MaxOddEven (int[] numbers , string neededIndexOf)
        {
            int index = 0;
            int maxNum = int.MinValue;

            if (neededIndexOf == "odd")
            {
                 maxNum = 1;
            }
            else if (neededIndexOf == "even")
            {
                 maxNum = int.MinValue;
            }
            
            bool isElements = false;

            if (neededIndexOf == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        isElements = true;
                        if (maxNum <= numbers[i])
                        {
                            index = i;
                            maxNum = numbers[i];
                        }
                    }
                }
            }
            else if (neededIndexOf == "even")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        isElements = true;
                        if (maxNum <= numbers[i])
                        {
                            maxNum = numbers[i];
                            index = i;
                        }
                    }
                }
            }

            if (!isElements)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MinOddEven (int[] numbers , string neededIndexOf)
        {
            int index = 0;
            int minNum = 0;
            bool isElements = false;

            if (neededIndexOf == "odd")
            {
                minNum = int.MaxValue;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        isElements = true;
                        if (minNum >= numbers[i])
                        {
                            minNum = numbers[i];
                            index = i;
                        }
                    }
                }
            }
            else if (neededIndexOf == "even")
            {
                minNum = int.MaxValue;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        isElements = true;

                        if (minNum >= numbers[i])
                        {
                            minNum = numbers[i];
                            index = i;
                        }
                    }
                }
            }
                 if (!isElements)
                 {
                        Console.WriteLine("No matches");
                 }
                 else
                 {
                     Console.WriteLine(index);
                 }
        }

        static void FirstOddsEvens (int[] numbers , int count , string neededKindOf)
        {
            int counter = 0;
            bool isValidCount = true;
            StringBuilder numbersInString = new StringBuilder();

            if (count > numbers.Length)
            {
                isValidCount = false;
                Console.WriteLine("Invalid count");
            }
            else if (neededKindOf == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        counter++;
                        if (counter <= count)
                        {
                            numbersInString.Append(numbers[i] + " ");
                        }
                    }
                }
            }
            else if(neededKindOf == "even")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        counter++;
                        if (counter <= count)
                        {
                            numbersInString.Append(numbers[i] + " ");
                        }
                    }
                }
            }

            int[] firstNums = numbersInString.ToString().Split(" " , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (counter == 0 && isValidCount)
            {
                Console.WriteLine("[]");
            }
            else if (isValidCount)
            {
                Console.WriteLine(string.Join(" " , firstNums));
            }

        }

        static void LastOddsEvens (int[] numbers , int count , string neededKindOf)
        {
            int counter = 0;
            bool isValidCount = true;
            StringBuilder numbersInString = new StringBuilder();

            if (count > numbers.Length)
            {
                isValidCount = false;
                Console.WriteLine("Invalid count");
            }
            else if (neededKindOf == "odd")
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        counter++;
                        if (counter <= count)
                        {
                            numbersInString.Append(numbers[i] + " ");
                        }
                    }
                }
            }
            else if (neededKindOf == "even")
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        counter++;
                        if (counter <= count)
                        {
                            numbersInString.Append(numbers[i] + " ");
                        }
                    }
                }
            }

            int[] firstNums = numbersInString.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (counter == 0 && isValidCount)
            {
                Console.WriteLine("[]");
            }
            else if (isValidCount)
            {
                Console.WriteLine(string.Join(" ", firstNums));
            }
        }
    }
}
