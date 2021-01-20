using EmployeeManagement;
using System;
using IKOMM.CustomLibrary;
using System.Collections.Generic;

namespace Lab_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baseArray = new string[] { "1", "2", "3", "4", "5" };
            string[] output = ArrayTools.Append(baseArray, "item to add1", "item to add2", "item to add3");
            //Console.WriteLine(output[output.Length-1]);

            var no1 = new Employee("Marius Kristiansen", 10000.0, new DateTime(2021, 01, 11));
            var no2 = new Employee("Ola Nordmann", 230_000.0);

            no1.Raise(25000);

            no1.AddSkill("Computers");
            no1.AddSkill("Testing");
            no1.AddSkill("This", "and this");
            no1.RemoveSkill("This");

            Console.WriteLine(no1);
            Console.WriteLine(no2);
            no2.UpdateUser();
            Console.WriteLine(new string('=', Console.WindowWidth));
            Console.WriteLine(no2);

            //List<Employee> employees = new List<Employee>();

            //Employee[] employees = new Employee[100];

            //for (int i = 0; i < 10; i++)
            //{
            //    employees[i] = new Employee();
            //}
        }
    }
}
