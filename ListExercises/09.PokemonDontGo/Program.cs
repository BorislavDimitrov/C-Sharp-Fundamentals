using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index <= numbers.Count - 1)
                {
                    sum += RemoveValueWithIndexInBounds(numbers, index);
                }
                else
                {
                    sum += RemoveValueWithIndexOutsideBounds(numbers , index);
                }
            }
            Console.WriteLine(sum);
        }

        static int RemoveValueWithIndexInBounds (List<int> numbers , int index)
        {
            int indexValue = numbers[index];
            numbers.RemoveAt(index);

            if (numbers.Count > 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= indexValue)
                    {
                        numbers[i] += indexValue;
                    }
                    else
                    {
                        numbers[i] -= indexValue;
                    }
                }
            }
            return indexValue;
        }

        static int RemoveValueWithIndexOutsideBounds (List<int> numbers , int index)
        {
            int indexValue = 0;

            if (index < 0)
            {
                indexValue = numbers[0];
                numbers[0] = numbers[numbers.Count - 1];
            }
            else if (index > numbers.Count - 1)
            {
                indexValue = numbers[numbers.Count - 1];
                numbers[numbers.Count - 1] = numbers[0];
            }

            if (numbers.Count > 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= indexValue)
                    {
                        numbers[i] += indexValue;
                    }
                    else
                    {
                        numbers[i] -= indexValue;
                    }
                }
            }
            return indexValue;
        }
    }
}
