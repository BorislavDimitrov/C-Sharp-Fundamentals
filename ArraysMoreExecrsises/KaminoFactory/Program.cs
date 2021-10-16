using System;
using System.Linq;

namespace _KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequencesLenth = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] dnaCode = new int[sequencesLenth];
            int samplesCount = 0;
            int[] bestDnaSample = new int[sequencesLenth];

            int onesCounter = 0;

            int indexOneStart = int.MaxValue;

            int sum = 0;
            int currentSampleCount = 0;
            while (input != "Clone them!")
            {
                dnaCode = input.Split("!" , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currentSampleCount++;
                int currentOnesCounter = 0;
                bool isSameLength = false;

                for (int i = 0; i < dnaCode.Length; i++)
                {
                    if (dnaCode[i] == 1)
                    {
                        currentOnesCounter++;
                        if (currentOnesCounter > onesCounter)
                        {
                            for (int j = 0; j < dnaCode.Length; j++)
                            {
                                bestDnaSample[j] = dnaCode[j];
                            }
                            samplesCount = currentSampleCount;
                            onesCounter = currentOnesCounter;
                            isSameLength = false;
                        }
                        else if (currentOnesCounter == onesCounter)
                        {
                            isSameLength = true;
                        }
                    }
                    else
                    {
                        currentOnesCounter = 0;
                    }
                }
               
                int currenIndexStartOfOnes = 0;
                int currentOnesCounterForIndex = 0;
                bool isSameIndex = false;

                if (isSameLength || currentSampleCount == 1)
                {
                    for (int i = 0; i < dnaCode.Length; i++)
                    {
                        if (dnaCode[i] == 1)
                        {
                            currentOnesCounterForIndex++;
                            if (currentOnesCounterForIndex == onesCounter)
                            {
                                currenIndexStartOfOnes = i - (currentOnesCounterForIndex - 1);
                                if (currenIndexStartOfOnes < indexOneStart)
                                {
                                    for (int j = 0; j < dnaCode.Length; j++)
                                    {
                                        bestDnaSample[j] = dnaCode[j];
                                    }
                                    samplesCount = currentSampleCount;
                                    indexOneStart = currenIndexStartOfOnes;
                                    isSameIndex = false;
                                }
                                else if (currenIndexStartOfOnes == indexOneStart)
                                {
                                    isSameIndex = true;
                                }
                            }
                        }
                        else
                        {
                            currentOnesCounterForIndex = 0;
                        }
                    }

                }
                int currentSum = 0;
                if (isSameIndex || currentSampleCount == 1)
                {
                    for (int i = 0; i < dnaCode.Length; i++)
                    {
                        currentSum += dnaCode[i];
                        if (currentSum > sum)
                        {
                            for (int j = 0; j < dnaCode.Length; j++)
                            {
                                bestDnaSample[j] = dnaCode[j];
                            }
                            currentSampleCount = samplesCount;
                            sum = currentSum;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            int finalSum = 0;
            for (int i = 0; i < bestDnaSample.Length; i++)
            {
                if (bestDnaSample[i] == 1)
                {
                    finalSum += 1;
                }
            }
            Console.WriteLine($"Best DNA sample {samplesCount} with sum: {finalSum}.");
            Console.WriteLine(String.Join(" " , bestDnaSample));
        }

    }
}

