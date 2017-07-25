namespace p01_GenericBox_chain
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            //// Problem 02.Generic Box of String
            //for (int i = 0; i < count; i++)
            //{
            //    Box<string> boxStr = new Box<string>(Console.ReadLine());
            //    Console.WriteLine(boxStr);
            //}

            //// Problem 03.Generic Box of Integer
            //for (int i = 0; i < count; i++)
            //{
            //    Box<int> boxStr = new Box<int>(int.Parse(Console.ReadLine()));
            //    Console.WriteLine(boxStr);
            //}


            //// Problem 04.Generic Swap Method Strings
            //List<Box<string>> boxes = new List<Box<string>>();
            //for (int i = 0; i < count; i++)
            //{
            //    boxes.Add(new Box<string>(Console.ReadLine()));
            //}

            //// Problem 05.Generic Swap Method Integers
            //List<Box<int>> boxes = new List<Box<int>>();
            //for (int i = 0; i < count; i++)
            //{
            //    boxes.Add(new Box<int>(int.Parse(Console.ReadLine())));
            //}

            //int[] swapIndxs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //SwapElements(boxes, swapIndxs[0], swapIndxs[1]);
            //foreach (var box in boxes)
            //{
            //    Console.WriteLine(box);
            //}


            //// Problems 06.Generic Count Method Strings (re-using code from problem 04)
            //string refValue = Console.ReadLine();
            //Console.WriteLine(CountGreaterElements(boxes, refValue));

            // Problems 07.Generic Count Method Doubles
            List<Box<double>> boxes = new List<Box<double>>();
            for (int i = 0; i < count; i++)
            {
                boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }

            double refValue = double.Parse(Console.ReadLine());
            Console.WriteLine(CountGreaterElements(boxes, refValue));

        }

        private static void SwapElements<T>(List<Box<T>> boxes, int firstInd, int secondInd)
        {
            Box<T> tempElement = boxes[firstInd];
            boxes[firstInd] = boxes[secondInd];
            boxes[secondInd] = tempElement;
        }

        private static int CountGreaterElements<T>(List<Box<T>> boxes, T refValue) where T : IComparable<T>
        {
            int count = 0;

            foreach (var box in boxes)
            {
                if (box.Value.CompareTo(refValue) > 0)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
