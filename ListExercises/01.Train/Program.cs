using System;
using System.Collections.Generic;
using System.Linq;

namespace GAUS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split().ToList();
                int commandNumber = 0;
                string commandText = string.Empty;
                bool isNum = int.TryParse(command[0] , out commandNumber);

                if (command.Count == 2)
                {
                    isNum = int.TryParse(command[1] , out commandNumber);
                    commandText= command[0];
                }

                if (commandText == "Add" && isNum == true)
                {
                    InsertWagon(numbers , commandNumber);
                }
                else if (isNum)
                {
                    FitPassengersInWagon(numbers ,commandNumber , wagonCapacity);
                }
                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void InsertWagon (List<int> wagons , int peopleNum)
        {
            wagons.Add(peopleNum);
        }

        static void FitPassengersInWagon (List<int> wagons , int passengers , int wagonCapacity)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + passengers <= wagonCapacity)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }
    }
}
