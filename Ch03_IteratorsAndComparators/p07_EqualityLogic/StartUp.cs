namespace p07_EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> personsSorted = new SortedSet<Person>();
            HashSet<Person> personsHash = new HashSet<Person>();

            int countPerson = int.Parse(Console.ReadLine());
            for (int i = 0; i < countPerson; i++)
            {
                string[] inPerson = Console.ReadLine().Split();
                Person newPerson = new Person(inPerson[0], int.Parse(inPerson[1]));

                personsSorted.Add(newPerson);
                personsHash.Add(newPerson);
            }

            Console.WriteLine(personsSorted.Count);
            Console.WriteLine(personsHash.Count);
        }
    }
}
