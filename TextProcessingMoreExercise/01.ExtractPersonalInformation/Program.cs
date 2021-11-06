using System;
using System.Text;

namespace _01.ExtractPersonalInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            StringBuilder name = new StringBuilder();
            StringBuilder age = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                for (int k = 0; k < text.Length; k++)
                {
                    if (text[k] == '@')
                    {
                        int j = k + 1;

                        while (text[j] != '|')
                        {
                            name.Append(text[j]);
                            j++;
                        }
                    }

                    if (text[k] == '#')
                    {
                        int j = k + 1;

                        while (text[j] != '*')
                        {
                            age.Append(text[j]);
                            j++;
                        }
                    }
                }
                Console.WriteLine($"{name} is {age} years old.");
                name.Clear();
                age.Clear();
            }
            
        }
    }
}
