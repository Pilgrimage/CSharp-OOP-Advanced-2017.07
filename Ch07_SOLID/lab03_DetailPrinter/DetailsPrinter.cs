﻿namespace lab03_DetailPrinter
{
    using System;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private readonly IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public void printDetails()
        {
            foreach (Employee employee in this.employees)
            {
                Console.WriteLine(employee);
            }
        }

    }
}