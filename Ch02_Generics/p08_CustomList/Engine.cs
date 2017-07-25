namespace p08_CustomList
{
    using System;

    public class Engine
    {
        private CustomList<string> customList;

        public Engine()
        {
            this.customList = new CustomList<string>();
        }

        public void Run()
        {
            this.Dispatch();
        }

        private void Dispatch()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var inParams = input.Split(' ');
                string command = inParams[0];

                switch (command)
                {
                    case "Add":
                        this.customList.Add(inParams[1]);
                        break;

                    case "Remove":
                        this.customList.Remove(int.Parse(inParams[1]));
                        break;

                    case "Contains":
                        Console.WriteLine(this.customList.Contains(inParams[1]));
                        break;

                    case "Swap":
                        this.customList.Swap(int.Parse(inParams[1]), int.Parse(inParams[2]));
                        break;

                    case "Greater":
                        Console.WriteLine(this.customList.CountGreaterThan(inParams[1]));
                        break;

                    case "Min":
                        Console.WriteLine(this.customList.Min());
                        break;

                    case "Max":
                        Console.WriteLine(this.customList.Max());
                        break;

                    case "Sort":
                        this.customList = Sorter.Sort(this.customList);
                        break;

                    case "Print":
                        foreach (string element in this.customList)
                        {
                            Console.WriteLine(element);
                        }
                        break;
                }
            }

        }
    }
}