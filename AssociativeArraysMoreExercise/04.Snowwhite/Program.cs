using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string , Dictionary<string , int>>();
            string input = string.Empty;
            List<Dwarf> listOfDwarfs = new List<Dwarf>();
            

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                List<string> dwarfInfo = input.Split(" <:> ").ToList();
                string dwarfName = dwarfInfo[0];
                string dwarfHatColor = dwarfInfo[1];
                int dwarfPhysic = int.Parse(dwarfInfo[2]);

                if (dwarfs.ContainsKey(dwarfName))
                {
                    if (dwarfs[dwarfName].ContainsKey(dwarfHatColor))
                    {
                        if (dwarfs[dwarfName][dwarfHatColor] < dwarfPhysic)
                        {
                            dwarfs[dwarfName][dwarfHatColor] = dwarfPhysic;
                        }                       
                    }
                    else
                    {
                        dwarfs[dwarfName].Add(dwarfHatColor , dwarfPhysic);
                    }
                }
                else
                {
                    var currentColor = new Dictionary<string,  int>();
                    currentColor.Add(dwarfHatColor , dwarfPhysic);
                    dwarfs.Add( dwarfName,currentColor);
                }
            }
            var countColors = new Dictionary<string, int>();
            MakeListWithDwarfs(dwarfs , listOfDwarfs);
            CountColorsInDictionary(dwarfs , countColors);
            PutTotalGroupColorCountOnDwarfs(countColors , listOfDwarfs);

            listOfDwarfs = listOfDwarfs.OrderByDescending(x => x.Physic).ThenByDescending(x => x.CountOfColorGroup).ToList();

            for (int i = 0; i < listOfDwarfs.Count; i++)
            {
                Console.WriteLine($"({listOfDwarfs[i].Color}) {listOfDwarfs[i].Name} <-> {listOfDwarfs[i].Physic}");
            }
        } 

        public static void MakeListWithDwarfs (Dictionary<string , Dictionary<string , int>> dwarfs , List<Dwarf> listOfDwarfs)
        {
            foreach (var name in dwarfs)
            {
                foreach (var color in name.Value)
                {
                    Dwarf currentDwarf = new Dwarf(name.Key , color.Key , color.Value);
                    listOfDwarfs.Add(currentDwarf);
                }
            }
        }

        public static void CountColorsInDictionary(Dictionary<string , Dictionary<string , int>> dwarfs , Dictionary<string , int> colors)
        {
            foreach (var name in dwarfs)
            {
                foreach (var color in name.Value)
                {
                    if (colors.ContainsKey(color.Key))
                    {
                        colors[color.Key]++;
                    }
                    else
                    {
                        colors.Add(color.Key , 1);
                    }
                }
            }
        }

        public static void PutTotalGroupColorCountOnDwarfs (Dictionary<string , int>colors ,List<Dwarf> listOfDwarfs)
        {
            for (int i = 0; i < listOfDwarfs.Count; i++)
            {
                foreach (var color in colors)
                {
                    if (listOfDwarfs[i].Color == color.Key)
                    {
                        listOfDwarfs[i].CountOfColorGroup = color.Value;
                    }
                }
            }
        }
    }
}
