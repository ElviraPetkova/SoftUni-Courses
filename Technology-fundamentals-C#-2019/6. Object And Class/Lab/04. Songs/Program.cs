using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSong = int.Parse(Console.ReadLine());

            List<Song> listOfSong = new List<Song>();

            for (int i = 0; i < numberOfSong; i++)
            {
                string[] info = Console.ReadLine().Split('_');
                string typeList = info[0];
                string name = info[1];
                string time = info[2];

                Song oneSong = new Song
                {
                    TypeList = typeList,
                    Name = name,
                    Time = time
                };

                listOfSong.Add(oneSong);
            }

            string type = Console.ReadLine();

            if(type == "all")
            {
                foreach (var item in listOfSong)
                {
                    string name = item.Name;
                    Console.WriteLine(name);
                }
            }
            else
            {
                var resultList = listOfSong.Where(x => x.TypeList == type).ToList();
                foreach (var item in resultList)
                {
                    string name = item.Name;
                    Console.WriteLine(name);
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
