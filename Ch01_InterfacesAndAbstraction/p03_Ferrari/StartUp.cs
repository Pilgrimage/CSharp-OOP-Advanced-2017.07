﻿namespace p03_Ferrari
{
    using System;
    using p03_Ferrari.Models;

    public class StartUp
    {
        public static void Main()
        {
            string driverName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driverName);
            Console.WriteLine(ferrari);
            
            //*************** TESTER *****************
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
