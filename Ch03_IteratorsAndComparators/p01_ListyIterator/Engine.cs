namespace p01_ListyIterator
{
    using System;
    using System.Linq;

    public class Engine
    {
        private ListyIterator<string> myIterator;
        
        public void Run()
        {
            this.InitializeCollection();
            this.Dispatch();
        }

        private void Dispatch()
        {
            string input;
            while ((input=Console.ReadLine())!="END")
            {
                switch (input)
                {
                    case "HasNext":
                        Console.WriteLine(this.myIterator.HasNext());
                        break;

                    case "Move":
                        Console.WriteLine(this.myIterator.Move());
                        break;

                    case "Print":
                        try
                        {
                            Console.WriteLine(this.myIterator.Print());
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;
                }
            }
        }

        private void InitializeCollection()
        {
            string[] inCreate = Console.ReadLine().Split();
            inCreate = inCreate.Skip(1).ToArray();
            this.myIterator = new ListyIterator<string>(inCreate);
        }
    }
}