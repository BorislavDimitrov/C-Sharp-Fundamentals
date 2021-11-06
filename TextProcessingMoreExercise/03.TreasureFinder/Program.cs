using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> key = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<StringBuilder> texts = new List<StringBuilder>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "find")
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(input);
                texts.Add(sb);
            }

            for (int i = 0; i < texts.Count; i++)
            {
                int count = 0;

                for (int j = 0; j < texts[i].Length; j++)
                {
                    char encrryptedChar = (char)((int)texts[i][j] - key[count]);
                    texts[i][j] = encrryptedChar;
                    count++;

                    if (count > key.Count - 1)
                    {
                        count = 0;
                    }
                }
            }

            for (int i = 0; i < texts.Count; i++)
            {
                StringBuilder type = new StringBuilder();
                StringBuilder coordinates = new StringBuilder();

                for (int j = 0; j < texts[i].Length; j++)
                {
                    if (texts[i][j] == '&')
                    {
                        for (int k = j + 1; k < texts[i].Length; k++)
                        {
                            if (texts[i][k] == '&')
                            {
                                j = k + 1;
                                break;
                            }
                            type.Append(texts[i][k]);
                        }
                    }

                    if (texts[i][j] == '<')
                    {
                        for (int k = j + 1; k < texts[i].Length; k++)
                        {
                            if (texts[i][k] == '>')
                            {
                                break;
                            }
                            coordinates.Append(texts[i][k]);
                        }
                    }
                }
                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
