using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using p07_FoodShortage.Entities;

namespace p07_FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            IList<IHuman> humans = new List<IHuman>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] inParams = Console.ReadLine().Split();

                if (inParams.Length == 3)
                {
                    humans.Add(new Rebel(inParams[0], int.Parse(inParams[1]), inParams[2]));
                }
                else if (inParams.Length == 4)
                {
                    humans.Add(new Citizen(inParams[0], int.Parse(inParams[1]), inParams[2], inParams[3]));
                }

            }

            string name;

            while ((name = Console.ReadLine()) != "End")
            {

                if (humans.FirstOrDefault(n => n.Name == name) != null)
                {
                    humans.FirstOrDefault(n => n.Name == name).BuyFood();
                }

            }

            Console.WriteLine(humans.Sum(n => n.Food));

        }
    }
}
