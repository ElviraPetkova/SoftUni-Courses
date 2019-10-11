using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Dwarf
    {
        public Dwarf(string name, string hatColor, int physics)
        {
            this.Name = name;
            this.HatColor = hatColor;
            this.Physics = physics;
        }

        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var listOfDwarHatColors = new Dictionary<string, List<Dwarf>>();
            var resultList = new List<Dwarf>();


            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Once upon a time")
                {
                    break;
                }

                var tokens = input.Split(new char[] { '<', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string colorOfHat = tokens[1];
                int physics = int.Parse(tokens[2]);

                Dwarf newDwarf = new Dwarf(name, colorOfHat, physics);

                if (listOfDwarHatColors.ContainsKey(colorOfHat) == false)
                {                   
                    listOfDwarHatColors.Add(colorOfHat, new List<Dwarf>());
                    listOfDwarHatColors[colorOfHat].Add(newDwarf);

                    resultList.Add(newDwarf);
                }
                else
                {
                    bool sameNamesAndColor = ChekingNameAndColorHat(listOfDwarHatColors, name, colorOfHat);

                    if(sameNamesAndColor == false)
                    {
                        listOfDwarHatColors[colorOfHat].Add(newDwarf);
                        resultList.Add(newDwarf);
                    }
                    else
                    {
                        ChangePhysics(listOfDwarHatColors, name, colorOfHat, physics);
                    }
                }
            }

            var result = resultList
                .OrderByDescending(x => x.Physics)
                .ThenByDescending(l => listOfDwarHatColors[l.HatColor].Count)
                .ToList();

            foreach (var dwarf in result)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        private static void ChangePhysics(Dictionary<string, List<Dwarf>> listOfDwarHatColors, string name, string colorOfHat, int physics)
        {
            foreach (var kvp in listOfDwarHatColors)
            {
                string color = kvp.Key;

                if(color == colorOfHat)
                {
                    foreach (var dwarf in kvp.Value)
                    {
                        if(dwarf.Name == name)
                        {
                            if(dwarf.Physics < physics)
                            {
                                dwarf.Physics = physics;
                            }
                        }
                    }
                }
            }
        }

        private static bool ChekingNameAndColorHat(Dictionary<string, List<Dwarf>> listOfDwarHatColors, string name, string colorOfHat)
        {
            bool haveSame = false;

            var currentListOfDwarf = listOfDwarHatColors[colorOfHat].ToList();
            foreach (var item in currentListOfDwarf)
            {
                string currentName = item.Name;

                if (currentName == name)
                {
                    haveSame = true;
                    break;
                }
            }

            return haveSame;
        }
    }
}
