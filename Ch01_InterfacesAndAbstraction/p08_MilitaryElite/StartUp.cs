namespace p08_MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using p08_MilitaryElite.Entities;
    using p08_MilitaryElite.Interfaces;

    public class StartUp
    {
        public static void Main()
        {
            IList<ISoldier> army;

            string input;
            army = new List<ISoldier>();

            while ((input = Console.ReadLine()) != "End")
            {
                var args = input.Split();
                string type = args[0];
                string id = args[1];

                switch (type)
                {
                    case "Private":
                        army.Add(new Private(id, args[2], args[3], double.Parse(args[4])));
                        break;

                    case "Spy":
                        army.Add(new Spy(id, args[2], args[3], int.Parse(args[4])));
                        break;

                    case "LeutenantGeneral":
                        LeutenantGeneral leutenantGeneral = new LeutenantGeneral(id, args[2], args[3], double.Parse(args[4]));

                        for (int i = 5; i < args.Length;i++)
                        {
                            leutenantGeneral.AddPrivate(army.First(s => s.Id == args[i]));
                        }

                        army.Add(leutenantGeneral);
                        break;

                    case "Commando":
                        Commando commando;

                        try
                        {
                            commando = new Commando(id, args[2], args[3], double.Parse(args[4]), args[5]);
                        }
                        catch (Exception)
                        {
                            break;
                        }

                        for (int i = 6; i < args.Length - 1; i += 2)
                        {
                            Mission mission;
                            try
                            {
                                mission = new Mission(args[i], args[i + 1]);
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                            commando.AddMission(mission);
                        }

                        army.Add(commando);
                        break;

                    case "Engineer":
                        Engineer engineer;
                        try
                        {
                            engineer = new Engineer(id, args[2], args[3], double.Parse(args[4]), args[5]);
                        }
                        catch (Exception)
                        {
                            break;
                        }

                        for (int i = 6; i < args.Length - 1; i += 2)
                        {
                            engineer.AddRepair(new Repair(args[i], int.Parse(args[i + 1])));
                        }

                        army.Add(engineer);
                        break;
                }
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }

        }

    }
}
