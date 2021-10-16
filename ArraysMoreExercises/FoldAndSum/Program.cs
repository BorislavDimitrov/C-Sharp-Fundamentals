using System;
using System.Linq;

namespace _FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
          
            int[] topRow = new int[nums.Length / 2];
            int[] midRow = new int[nums.Length / 2];
            int indexSelection = (nums.Length / 2) / 2;
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i >=  0 && i < indexSelection)
                {
                    topRow[i] = nums[i];
                }
                else if (i >= nums.Length  - (indexSelection) && i < nums.Length)
                {
                    topRow[i - indexSelection * 2] = nums[i];
                }
                else
                {
                    midRow[counter] = nums[i];
                    counter++;
                }
            }
            
            int[] reversedEnds = new int[indexSelection];
                                                                                      // put the array in new array
            for (int i = 0; i < reversedEnds.Length; i++)                             // put the array in new array
            {                                                                         // put the array in new array
                reversedEnds[i] = topRow[i];                                          // put the array in new array
            }
                                                                                        // reverse the elements in the new array
            for (int j = 0; j < reversedEnds.Length / 2; j++)                           // reverse the elements in the new array
            {                                                                           // reverse the elements in the new array
                int temp = reversedEnds[j];                                             // reverse the elements in the new array
                reversedEnds[j] = reversedEnds[reversedEnds.Length - 1 - j];            // reverse the elements in the new array
                reversedEnds[reversedEnds.Length - 1 - j] = temp;
            }
                                                                                          // then put the reversed elemnts back to the old array
            for (int i = 0; i < reversedEnds.Length; i++)                                 // then put the reversed elemnts back to the old array
            {                                                                             // then put the reversed elemnts back to the old array
                topRow[i] = reversedEnds[i];                                              // then put the reversed elemnts back to the old array
            }

            
            for (int k = topRow.Length - indexSelection; k < topRow.Length; k++)
            {
                reversedEnds[k - indexSelection] = topRow[k];
            }

            for (int j = 0; j < reversedEnds.Length / 2; j++)
            {
                int temp = reversedEnds[j];
                reversedEnds[j] = reversedEnds[reversedEnds.Length - 1 - j];
                reversedEnds[reversedEnds.Length - 1 - j] = temp;
            }
         
            for (int i = 0; i < reversedEnds.Length; i++)
            {
                topRow[i + indexSelection] = reversedEnds[i];
            }

            for (int i = 0; i < topRow.Length; i++)
            {
               topRow[i] += midRow[i];
            }
            Console.WriteLine(string.Join(" " , topRow));
        }
    }
}
