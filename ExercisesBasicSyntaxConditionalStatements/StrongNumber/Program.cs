using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int factorielsSum = 0;

            string number = num.ToString();
            for (int i = 0; i <= number.Length - 1; i++)
            {
                int currentIndex = int.Parse(number[i].ToString());
                int currentFactoriel = currentIndex;

                if (currentFactoriel == 0 || currentFactoriel == 1)
                {
                    factorielsSum += 1;
                    continue;
                }

                for (int j = currentIndex - 1; j >= 1; j--)
                {
                    
                    currentFactoriel *= j;

                    if (j == 1)
                    {
                        factorielsSum += currentFactoriel;
                    }
                }
            }
            if (factorielsSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {   
                Console.WriteLine("no");
            }
        }
    }
}
