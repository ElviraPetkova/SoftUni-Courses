namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Models.SpySoldiers;
    using Models.Privates;
    using Models.Privates.SpecialisedSoldiers;

    public class Startup
    {
        static void Main(string[] args)
        {
            HashSet<Soldier> soldiers = new HashSet<Soldier>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] soldierArguments = input.Split(" ");

                string soldierType = soldierArguments[0];
                string id = soldierArguments[1];
                string firstName = soldierArguments[2];
                string lastName = soldierArguments[3];

                if(soldierType == "Private")
                {
                    decimal salary = decimal.Parse(soldierArguments[4]);

                    Private @private = new Private(id, firstName, lastName, salary);

                    soldiers.Add(@private);
                }
                else if(soldierType == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(soldierArguments[4]);
                    List<string> ids = soldierArguments.Skip(5).ToList();

                    LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    List<Private> privates = GetPrivates(ids, soldiers);

                    foreach (var item in privates)
                    {
                        lieutenantGeneral.AddPrivates(item);
                    }

                    soldiers.Add(lieutenantGeneral);
                }
                else if(soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(soldierArguments[4]);
                    string corps = soldierArguments[5];
                    List<string> repairsArg = soldierArguments.Skip(6).ToList();

                    HashSet<Repair> repairs = GetRepairs(repairsArg);

                    try
                    {
                        Engineer engineer = new Engineer(id, firstName, lastName, salary, corps, repairs);
                        soldiers.Add(engineer);
                    }
                    catch(Exception)
                    {
                    }

                }
                else if (soldierType == "Commando")
                {
                    decimal salary = decimal.Parse(soldierArguments[4]);
                    string corps = soldierArguments[5];
                    List<string> missionArgs = soldierArguments.Skip(6).ToList();

                    HashSet<Mission> missions = GetMission(missionArgs);

                    try
                    {
                        Commando commando = new Commando(id, firstName, lastName, salary, corps, missions);
                        soldiers.Add(commando);
                    }
                    catch(Exception)
                    {
                    }
                }
                else if(soldierType == "Spy")
                {
                    int codeNumber = int.Parse(soldierArguments[4]);

                    Spy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiers.Add(spy);
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private static HashSet<Mission> GetMission(List<string> missionArgs)
        {
            HashSet<Mission> missions = new HashSet<Mission>();

            for (int i = 0; i < missionArgs.Count; i += 2)
            {
                string coldName = missionArgs[i];
                string state = missionArgs[i + 1];

                try
                {
                    Mission mission = new Mission(coldName, state);
                    missions.Add(mission);
                }
                catch(Exception)
                {
                }
            }

            return missions;
        }

        private static HashSet<Repair> GetRepairs(List<string> repairsArg)
        {
            HashSet<Repair> repairs = new HashSet<Repair>();

            for (int i = 0; i < repairsArg.Count; i+=2)
            {
                string partName = repairsArg[i];
                int hoursWorked = int.Parse(repairsArg[i + 1]);

                Repair repair = new Repair(partName, hoursWorked);

                repairs.Add(repair);
            }

            return repairs;
        }

        private static List<Private> GetPrivates(List<string> ids, HashSet<Soldier> soldiers)
        {
            List<Private> privates = new List<Private>();
            List<Soldier> filterSoldiers = soldiers
                .Where(x => x.GetType().Name == nameof(Private))
                .ToList();

            foreach (var id in ids)
            {
                if (soldiers.Select(x=>x.Id).Contains(id))
                {
                    Private @private = (Private)soldiers
                        .FirstOrDefault(x => x.Id == id);
                    privates.Add(@private);
                }
            }

            return privates;
        }
    }
}
