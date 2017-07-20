namespace p06_BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            IList<IBirthday> celebrating = new List<IBirthday>();
            IList<IRobot> terminators = new List<IRobot>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inParams = input.Split();
                string type = inParams[0].ToLower();

                switch (type)
                {
                    case "citizen":
                        celebrating.Add(new Citizen(inParams[1], int.Parse(inParams[2]), inParams[3], inParams[4]));
                        break;
                    case "pet":
                        celebrating.Add(new Pet(inParams[1], inParams[2]));
                        break;
                    case "robot":
                        terminators.Add(new Robot(inParams[1], inParams[2])); break;
                }
            }

            string code = Console.ReadLine();
            var party = celebrating.Where(x => x.BirthDate.EndsWith(code)).Select(x => x.BirthDate);
            Console.WriteLine(string.Join(Environment.NewLine, party));
        }
    }
}
