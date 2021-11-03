using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            int strength = 0;

            for (int i = 0; i < sb.Length; i++)
            {               
                if (sb[i] == '>')
                {                   
                    strength += int.Parse(sb[i + 1].ToString());

                    for (int j = i + 1; j <= sb.Length; j++)
                    {
                        if (j > sb.Length - 1)
                        {
                            break;
                        }

                        if (sb[j] != '>')
                        {
                            sb[j] = '*';
                            strength--;
                            
                            if (strength == 0)
                            {
                                strength = 0;
                                break;
                            }
                        }
                        else if (sb[j] == '>')
                        {
                            break;
                        }
                    }
                }
            }
            sb.Replace("*" , "");
            Console.WriteLine(sb);
        }
    }
}
