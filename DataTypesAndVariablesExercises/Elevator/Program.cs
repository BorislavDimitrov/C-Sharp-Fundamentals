using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int coursesNeeded = 0;
            int diff = peopleNum;
            if (peopleNum < elevatorCapacity)
            {
                coursesNeeded++;
                Console.WriteLine(coursesNeeded);
                return;
            }
             coursesNeeded = peopleNum / elevatorCapacity;
            diff -= coursesNeeded * elevatorCapacity;
            if (diff != 0)
            {
                coursesNeeded++;
            }

            Console.WriteLine(coursesNeeded);
            
        }
    }
}
