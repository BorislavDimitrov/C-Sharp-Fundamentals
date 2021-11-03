using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.LettersChange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> seqences = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).ToList();
            List<double> results = new List<double>();

            for (int i = 0; i < seqences.Count; i++)
            {
                string currentSeq = seqences[i];
                char beforeChar = currentSeq[0];
                double beforeCharAlphabetNum = GetAlphabetPositionOfChar(beforeChar);
                char afterChar = currentSeq[currentSeq.Length - 1];
                double afterCharAlphabetNum = GetAlphabetPositionOfChar(afterChar);
                double currSeqNumPart = GetNumberPartFromSequence(currentSeq);
                double currentSequenceResult = 0;

                if (char.IsUpper(beforeChar))
                {
                    currentSequenceResult += currSeqNumPart / beforeCharAlphabetNum;
                }
                else
                {
                    currentSequenceResult += currSeqNumPart * beforeCharAlphabetNum;
                }

                if (char.IsUpper(afterChar))
                {
                    currentSequenceResult -= afterCharAlphabetNum;
                }
                else
                {
                    currentSequenceResult += afterCharAlphabetNum;
                }
                results.Add(currentSequenceResult);
            }

            double finalResult = results.Sum();
            Console.WriteLine($"{finalResult:F2}");
        }

        public static int GetAlphabetPositionOfChar (char someChar)
        {
            int charPosition = 0;

            if (char.IsLower(someChar))
            {
                charPosition = (int)someChar - 96;
            }
            else if (char.IsUpper(someChar))
            {
                charPosition = (int)someChar - 64;
            }

            return charPosition;
        }

        public static int GetNumberPartFromSequence(string sequence)
        {
            int number = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < sequence.Length - 1; i++)
            {
                sb.Append(sequence[i]);
            }

            number = int.Parse(sb.ToString());
            return number;
        }
    }
}
