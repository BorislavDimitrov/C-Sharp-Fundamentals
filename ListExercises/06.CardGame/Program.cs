using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstHand.Count > 0 && secondHand.Count > 0)
            {
                int firstHandCard = firstHand[0];
                int secondHandCard = secondHand[0];

                if (firstHandCard > secondHandCard)
                {
                    firstHand.Add(firstHandCard);
                    firstHand.Add(secondHandCard);
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
                else if (secondHandCard > firstHandCard)
                {
                    secondHand.Add(secondHandCard);
                    secondHand.Add(firstHandCard);
                    secondHand.RemoveAt(0);
                    firstHand.RemoveAt(0);
                }
                else if (firstHandCard == secondHandCard)
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
            }

            if (firstHand.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }
    }
}
