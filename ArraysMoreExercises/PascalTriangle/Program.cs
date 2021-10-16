using System;

namespace _PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[1];
            int[] array2 = new int[1];

            array1[0] = 1;
            array2[0] = 1;
           

            for (int i = 1; i <= n; i++)
            {
                bool isEven = false;

                if (i % 2 != 0)
                {
                    array1 = new int[i];
                    array1[0] = 1;
                    
                }
                else
                {
                    array2 = new int[i];
                    array2[0] = 1;
                    isEven = true;
                }
                for (int j = 1; j < i; j++)
                {
                    if (!isEven)
                    {
                        if (j > array2.Length - 1)
                        {
                            array1[j] = 1;
                        }
                        else
                        {
                        array1[j] = array2[j] + array2[j - 1];
                        
                        } 
                    }
                    else
                    {
                        if (j > array1.Length -1)
                        {
                            array2[j] = 1;
                        }
                        else
                        {
                            array2[j] = array1[j] + array1[j - 1];
                            
                        }
                        
                    }
                }
                if (!isEven)
                {
                    Console.WriteLine(string.Join(" ", array1));
                }
                else
                {
                    Console.WriteLine(string.Join(" ", array2));
                }
            }
        }
    }
}
