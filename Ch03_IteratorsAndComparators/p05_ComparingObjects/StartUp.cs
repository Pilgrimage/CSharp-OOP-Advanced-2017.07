namespace p05_ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            string input;
            string result = "No matches";
            int equalPersons = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inParams = input.Split();
                people.Add(new Person(inParams[0], int.Parse(inParams[1]), inParams[2]));
            }

            int referentPersonIndex = int.Parse(Console.ReadLine());
            Person referentPerson = people[referentPersonIndex - 1];

            foreach (Person person in people)
            {
                if (person.CompareTo(referentPerson) == 0)
                {
                    equalPersons++;
                }
            }

            if (equalPersons > 1)
            {
                result = $"{equalPersons} {people.Count - equalPersons} {people.Count}";
            }

            Console.WriteLine(result);
        }
    }
}
