using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double leftCarTime = LeftCarTime(numbers);
            double rightCarTime = RightCarTime(numbers);

            if (leftCarTime < rightCarTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftCarTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCarTime}");
            }
        }

        static double LeftCarTime (List<int> numbers)
        {
            double carTime = 0;
            bool containsZero = false;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                carTime += numbers[i];

                if (numbers[i] == 0)
                {
                    containsZero = true;
                }

                if (containsZero)
                {
                    carTime -= carTime * 1.00 * 20 / 100;
                }
                containsZero = false;
            }
           
            return  carTime;
        }

        static double RightCarTime (List<int> numbers)
        {
            double carTime = 0;
            bool containsZero = false;

            for (int i = numbers.Count- 1; i > numbers.Count / 2; i--)
            {
                carTime += numbers[i];
                if (numbers[i] == 0)
                {
                    containsZero = true;
                }

                if (containsZero)
                {
                    carTime -= carTime * 20 / 100;
                }

                containsZero = false;
            }

            return carTime;
        }
    }
}
