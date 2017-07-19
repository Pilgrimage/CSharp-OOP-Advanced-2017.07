using System.Collections.Generic;
using System.Linq;
using p05_BorderControl.Models;

namespace p05_BorderControl
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            List<IEnterable> invaders = new List<IEnterable>();

            string input;

            while ((input= Console.ReadLine()) !="End")
            {
                string[] inParams = input.Split();

                if (inParams.Length==2)
                {
                    invaders.Add(new Robot(inParams[1], inParams[0]));
                }
                else if (inParams.Length == 3)
                {
                    invaders.Add(new Citizen(inParams[2], inParams[0], int.Parse(inParams[1])));
                }
            }

            string cityKey = Console.ReadLine();

            Console.WriteLine(string.Join(Environment.NewLine, invaders.Where(x=>x.IsDetained(cityKey)).Select(x=>x.Id)));

        }
    }
}
