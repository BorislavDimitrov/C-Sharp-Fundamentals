using System;
using System.Linq;

namespace _Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonNum = int.Parse(Console.ReadLine());
            int[] train = new int[wagonNum];
            int sum = 0;
            for (int i = 0; i < wagonNum; i++)
            {
                int currentWagonPeopleNum = int.Parse(Console.ReadLine());
                train[i] = currentWagonPeopleNum;
                sum += currentWagonPeopleNum;
            }
            Console.WriteLine(String.Join(" " , train));
            Console.WriteLine(sum);
        }
    }
}
