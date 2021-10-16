using System;
using System.Linq;

namespace _EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            if (firstArray.Length != secondArray.Length)
            {
                bool isBigger = firstArray.Length > secondArray.Length;

                if (isBigger)
                {
                    for (int i = 0; i < firstArray.Length - 1; i++)
                    {
                        if ( (i <= secondArray.Length - 1))
                        {
                            if (firstArray[i] == secondArray[i])
                            {
                                return;
                            }
                            else
                            {
                                Console.Write($"Arrays are not identical. Found difference at {i} index");
                                return;
                            }
                        }
                        else
                        {
                            Console.Write($"Arrays are not identical. Found difference at {i} index");
                            return;
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < secondArray.Length; i++)
                    {
                        if ( firstArray.Length - 1 >= i)
                        {
                            if (firstArray[i] == secondArray[i])
                            {
                                continue;
                            }
                            else
                            {
                                Console.Write($"Arrays are not identical. Found difference at {i} index");
                                return;
                            }
                        }
                        else
                        {
                            Console.Write($"Arrays are not identical. Found difference at {i} index");
                            return;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        
                        sum += firstArray[i];
                        continue;
                    }
                    else
                    {
                        Console.Write($"Arrays are not identical. Found difference at {i} index ");
                        return;
                    }
                }
            }
            Console.Write("Arrays are identical. ");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
