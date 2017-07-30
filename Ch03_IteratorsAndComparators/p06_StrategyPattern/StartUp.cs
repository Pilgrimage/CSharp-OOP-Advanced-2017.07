namespace p06_StrategyPattern
{
    using System;
    using System.Collections.Generic;
    using Comparators;

    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> peopleSortedByName = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> peopleSortedByAge = new SortedSet<Person>(new AgeComparator());

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] inParams = Console.ReadLine().Split();
                Person person = new Person(inParams[0], int.Parse(inParams[1]));

                peopleSortedByName.Add(person);
                peopleSortedByAge.Add(person);
            }

            foreach (var person in peopleSortedByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in peopleSortedByAge)
            {
                Console.WriteLine(person);
            }

        }
    }
}
