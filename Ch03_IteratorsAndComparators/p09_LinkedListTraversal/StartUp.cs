namespace p09_LinkedListTraversal
{
    using System;
    using Models;

    public class StartUp
    {
        public static void Main()
        {

            MyLinkedList<int> myList = new MyLinkedList<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] inParams = Console.ReadLine().Split();
                string command = inParams[0];
                int argument = int.Parse(inParams[1]);

                switch (command)
                {
                    case "Add":
                        myList.AddLast(argument);
                        break;

                    case "Remove":
                        myList.Remove(argument);
                        break;
                }
            }

            Console.WriteLine(myList.Count);
            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
