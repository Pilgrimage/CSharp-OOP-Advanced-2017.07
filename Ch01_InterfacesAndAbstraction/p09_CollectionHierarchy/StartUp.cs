using System;
using System.Text;

namespace p09_CollectionHierarchy
{
    public class StartUp
    {
        public static void Main()
        {
            // Based ot state solution

            IAddCollection<string> addColletion = new AddCollection<string>();
            IAddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
            IMyList<string> myList = new MyList<string>();

            string[] itemsToAdd = Console.ReadLine().Split(' ');
            int removeOperationsCount = int.Parse(Console.ReadLine());

            StringBuilder addCollAddIndexes = new StringBuilder();
            StringBuilder addRemCollAddIndexes = new StringBuilder();
            StringBuilder myListCollAddIndexes = new StringBuilder();

            foreach (var item in itemsToAdd)
            {
                addCollAddIndexes.Append($"{addColletion.Add(item)} ");
                addRemCollAddIndexes.Append($"{addRemoveCollection.Add(item)} ");
                myListCollAddIndexes.Append($"{myList.Add(item)} ");
            }

            StringBuilder addRemCollRemoveElements = new StringBuilder();
            StringBuilder myListRemoveElements = new StringBuilder();

            for (int i = 0; i < removeOperationsCount; i++)
            {
                addRemCollRemoveElements.Append($"{addRemoveCollection.Remove()} ");
                myListRemoveElements.Append($"{myList.Remove()} ");
            }

            Console.WriteLine(addCollAddIndexes.ToString().Trim());
            Console.WriteLine(addRemCollAddIndexes.ToString().Trim());
            Console.WriteLine(myListCollAddIndexes.ToString().Trim());

            Console.WriteLine(addRemCollRemoveElements.ToString().Trim());
            Console.WriteLine(myListRemoveElements.ToString().Trim());
        }
    }
}
