using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex paternDemons = new Regex(@"[^((, ))]+");
            List<string> demonsName = paternDemons.Matches(input)
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToList();
            Regex healthPattern = new Regex(@"[^0-9+\-*\/\.]");
            Regex damagePattern = new Regex(@"\+|-?[0-9]+\.?[0-9]*");
            Regex damageProcessingPattern = new Regex(@"[*\/]");
            Dictionary<string, List<string>> demons = new Dictionary<string, List<string>>();

            for (int i = 0; i < demonsName.Count; i++)
            {
                var healthLetters = healthPattern.Matches(demonsName[i]);
                int health = CalculateDemonHealth(healthLetters);
                var damageLetters = damagePattern.Matches(demonsName[i]);
                double nonproceededDamage = CalculateDemonDamage(damageLetters);
                var damageProcessingLetters = damageProcessingPattern.Matches(demonsName[i]);
                double proceededDamage = CalculationsOnDamage(nonproceededDamage , damageProcessingLetters);
                List<string> tempList = new List<string>();
                tempList.Add(health.ToString());
                tempList.Add(proceededDamage.ToString());              
                demons.Add(demonsName[i] , tempList);
            }

            demons = demons.OrderBy(x => x.Key).ToDictionary(x => x.Key , y => y.Value);

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {double.Parse(demon.Value[1]):F2} damage");
            }
        }

        public static int CalculateDemonHealth (MatchCollection healthLetters)
        {
            int health = 0;

            foreach (Match match in healthLetters)
            {
                char temp = match.Value[0];
                health += (int)temp;
            }
            return health;
        }

        public static double CalculateDemonDamage (MatchCollection damageLetters)
        {
            double damage = 0;

            foreach (Match match in damageLetters)
            {
                string temp = match.Value;
                StringBuilder tempSb = new StringBuilder();
                tempSb.Append(temp);
                double tempDamage;
                if (tempSb[0] == '-')
                {
                    tempSb.Remove(0,1);
                     tempDamage = double.Parse(tempSb.ToString());
                    damage -= tempDamage;
                }
                else if (tempSb[0] == '+')
                {
                    tempSb.Remove(0,1);
                    tempDamage = double.Parse(tempSb.ToString());
                    damage += tempDamage;
                }
                else
                {
                    tempDamage = double.Parse(tempSb.ToString());
                    damage += tempDamage;
                }
            }
            return damage;
        }

        public static double CalculationsOnDamage (double nonproceededDamage ,MatchCollection damageProcessingLetters )
        {
            double damage = nonproceededDamage;

            foreach (Match match in damageProcessingLetters)
            {
                if (match.Value == "*")
                {
                    damage = damage * 2;
                }
                else if (match.Value == "/")
                {
                    damage = damage / 2;
                }
            }
            return damage;
        }
    }
}
