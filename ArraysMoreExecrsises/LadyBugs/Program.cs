using System;
using System.Linq;

namespace _LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] initialLadybugs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < initialLadybugs.Length; j++)
                {
                    if (i == initialLadybugs[j])
                    {
                        field[i] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" " , field));
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int startingPosition = 0;
                int flySteps = 0;
                string directionToFlyTo = command[1];
                bool isFirstInt = int.TryParse(command[0] , out startingPosition );
                bool isSecondInt = int.TryParse(command[2] , out flySteps);
                bool outsideLength = false;
                int newPosition = 0;
                if (directionToFlyTo == "left")
                {
                    newPosition = startingPosition - flySteps;
                }
                else if (directionToFlyTo == "right")
                {
                    newPosition = startingPosition + flySteps;
                }
                
                if (directionToFlyTo == "left")
                {
                    field[startingPosition] = 0;
                    if (newPosition < 0)
                    {
                        outsideLength = true;  
                    }
                    if (!outsideLength)
                    {
                        if (field[newPosition] == 1)
                        {
                            do
                            {
                                newPosition -= flySteps;
                                if (newPosition < 0)
                                {
                                    outsideLength = true;
                                    break;
                                }
                            } while (field[newPosition] == 1);

                            if (!outsideLength)
                            {
                                field[newPosition] = 1;
                            }

                        }
                        else if (field[newPosition] == 0 )
                        {
                            field[newPosition] = 1;
                        }
                    }  
                }
               else if (directionToFlyTo == "right")
               {
                    field[startingPosition] = 0;
                    if (newPosition > field.Length - 1 || newPosition < 0)
                    {
                        outsideLength = true;
                    }
                    if (!outsideLength)
                    {
                        if (field[newPosition] == 1)
                        {
                            do
                            {
                                newPosition += flySteps;
                                if (newPosition > field.Length - 1)
                                {
                                    outsideLength = true;
                                    break;
                                }
                            } while (field[newPosition] == 1);

                            if (!outsideLength)
                            {
                                field[newPosition] = 1;
                            }

                        }
                        else if (field[newPosition] == 0)
                        {
                            field[newPosition] = 1;
                        }
                    }
                }

                Console.WriteLine(string.Join(" " , field));
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
