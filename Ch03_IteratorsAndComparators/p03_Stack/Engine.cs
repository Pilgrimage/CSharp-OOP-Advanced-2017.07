namespace p03_Stack
{
    using System;
    using System.Linq;

    public class Engine
    {
        private Stack<int> myStack;
        private bool isStarted;

        public Engine()
        {
            this.myStack = new Stack<int>();
            this.isStarted = true;
        }

        public void Run()
        {
            this.Dispatch();
        }

        private void Dispatch()
        {
            while (this.isStarted)
            {
                string[] inParams = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                string command = inParams[0];
                inParams = inParams.Skip(1).ToArray();

                switch (command)
                {
                    case "Push":
                        foreach (var item in inParams)
                        {
                            this.myStack.Push(int.Parse(item));
                        }
                        break;

                    case "Pop":
                        try
                        {
                            this.myStack.Pop();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;

                    case "END":
                        this.isStarted = false;
                        for (int i = 0; i < 2; i++)
                        {
                            foreach (var item in this.myStack)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                }
            }
        }

    }
}