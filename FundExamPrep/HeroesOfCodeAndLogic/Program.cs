using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> heroesHpManaDict = new Dictionary<string, List<double>>();
            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < n; i++)
            {
                List<string> heroInfo = Console.ReadLine().Split().ToList();
                string heroName = heroInfo[0];
                double heroHealtPoints = double.Parse(heroInfo[1]);
                double heroManaPoints = double.Parse(heroInfo[2]);
                List<double> healthAndMana = new List<double>();

                healthAndMana.Add(heroHealtPoints);
                healthAndMana.Add(heroManaPoints);
                heroesHpManaDict.Add(heroName , healthAndMana);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commandInfo = input.Split(" - ").ToList();
                string firstCommand = commandInfo[0];
                string heroName = commandInfo[1];
                double manaPoints = 0;
                string spellName = string.Empty;
                double damage = 0;
                string attacker = string.Empty;
                double healthToHeal = 0;

                if (firstCommand == "CastSpell")
                {
                    manaPoints = double.Parse(commandInfo[2]);
                    spellName = commandInfo[3];

                    if (heroesHpManaDict[heroName][1] >= manaPoints)
                    {
                        heroesHpManaDict[heroName][1] -= manaPoints;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesHpManaDict[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (firstCommand == "TakeDamage")
                {
                    damage = double.Parse(commandInfo[2]);
                    attacker = commandInfo[3];

                    heroesHpManaDict[heroName][0] -= damage;

                    if (heroesHpManaDict[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHpManaDict[heroName][0]} HP left!");
                    }
                    else
                    {
                        heroesHpManaDict.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (firstCommand == "Recharge")
                {
                    manaPoints = double.Parse(commandInfo[2]);

                    if (heroesHpManaDict[heroName][1] + manaPoints > 200)
                    {
                        double diff = 200 - heroesHpManaDict[heroName][1];
                        Console.WriteLine($"{heroName} recharged for {diff} MP!");
                        heroesHpManaDict[heroName][1] = 200;
                    }
                    else
                    {
                        heroesHpManaDict[heroName][1] += manaPoints;
                        Console.WriteLine($"{heroName} recharged for {manaPoints} MP!");
                    }
                }
                else if (firstCommand == "Heal")
                {
                    healthToHeal = double.Parse(commandInfo[2]);

                    if (heroesHpManaDict[heroName][0] + healthToHeal > 100)
                    {
                        double diff = 100 - heroesHpManaDict[heroName][0];
                        Console.WriteLine($"{heroName} healed for {diff} HP!");
                        heroesHpManaDict[heroName][0] = 100;
                    }
                    else
                    {
                        heroesHpManaDict[heroName][0] += healthToHeal;
                        Console.WriteLine($"{heroName} healed for {healthToHeal} HP!");
                    }
                }
            }

            foreach (var hero in heroesHpManaDict)
            {
                Hero newHero = new Hero(hero.Key , hero.Value[0] , hero.Value[1]);
                heroes.Add(newHero);
            }

            heroes = heroes.OrderByDescending(x => x.HealthPoints).ThenBy(x => x.Name).ToList();

            for (int i = 0; i < heroes.Count; i++)
            {
                Console.WriteLine($"{heroes[i].Name}");
                Console.WriteLine($"HP: {heroes[i].HealthPoints}");
                Console.WriteLine($"MP: {heroes[i].ManaPoints}");
            }
        }
    }
}
