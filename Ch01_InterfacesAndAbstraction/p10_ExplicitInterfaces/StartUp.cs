using System;

namespace p10_ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main()
        {
            // Based on state solution

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inParams = input.Split(' ');
                string name = inParams[0];
                string country = inParams[1];
                int age = int.Parse(inParams[2]);

                Citizen citizen = new Citizen(name, country, age);
                IResident resident = citizen;
                IPerson person = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
