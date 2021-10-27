using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List <Song> allSongs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                List<string> input = Console.ReadLine().Split("_").ToList();
                string typeList = input[0];
                string songName = input[1];
                string time = input[2];

                Song song = new Song();

                song.TypeList = typeList;
                song.Name = songName;
                song.Time = time;

                allSongs.Add(song);
            }

            string listType = Console.ReadLine();

            if (listType == "all")
            {
                for (int i = 0; i < allSongs.Count; i++)
                {
                    Console.WriteLine(allSongs[i].Name);
                }
            }
            else
            {
                for (int i = 0; i < allSongs.Count; i++)
                {
                    if (allSongs[i].TypeList == listType)
                    {
                        Console.WriteLine(allSongs[i].Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
