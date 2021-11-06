using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string morse = "A, .-,  B, -..., C, -.-., D, -.., E, ., F, ..-., " +
                "G, --., H, ...., I, .., J, .---, K, -.-, L, .-.., " +
                "M, --, N, -., O, ---, P, .--., Q, --.-, R, .-., " +
                "S, ..., T, -, U, ..-, V, ...-, W, .--, X, -..-, " +
                "Y, -.--, Z, --..";

            List<string> info = morse.Split(", ").ToList();
            List<string> input = Console.ReadLine().Split().ToList();
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < info.Count; j++)
                {
                    if (input[i] == "|")
                    {
                        sb.Append(input[i]);
                        break;
                    }

                    if (input[i] == info[j])
                    {
                        sb.Append(info[j - 1]);
                        break;
                    }
                }
            }
            sb.Replace("|" , " ");
            Console.WriteLine(sb);
        }
    }
}
