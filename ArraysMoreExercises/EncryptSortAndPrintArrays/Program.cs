using System;

namespace _EncryptSortAndPrintArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] words = new string[num];
            int[] sums = new int[words.Length];
            for (int i = 0; i < num; i++)
            {
                words[i] = Console.ReadLine();
            }
            int counter = 0;
            
            foreach (string word in words)
            {
                int totalSum = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    int vowelSum = 0;
                    int consonantSum = 0;
                    if (word[j] == 'a' || word[j] == 'A' || word[j] == 'e' || word[j] == 'E' || word[j] == 'i' || word[j] == 'I' ||
                        word[j] == 'i' || word[j] == 'o' || word[j] == 'O' || word[j] == 'U' || word[j] == 'u' //|| word[j] == 'Y' || word[j] == 'y'
                        )
                    {
                        vowelSum += word[j] * word.Length;
                        totalSum += vowelSum;
                    }
                    else
                    {
                        consonantSum += word[j] / word.Length;
                        totalSum += consonantSum;
                    }
                }
                sums[counter] = totalSum;
                counter++;
            }

            for (int i = 0; i < sums.Length; i++)
            {
                for (int j = 0; j < sums.Length - 1; j++)
                {
                    if (sums[j] > sums[j + 1] )
                    {
                        int temp = sums[j];
                        sums[j] = sums[j + 1];
                        sums[j + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < sums.Length; i++)
            {
                Console.WriteLine(sums[i]);
            }
        }
    }
}
