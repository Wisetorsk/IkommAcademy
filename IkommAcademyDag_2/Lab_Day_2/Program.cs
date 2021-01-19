using EmployeeManagement;
using System;

namespace Lab_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var no1 = new Employee("Marius Kristiansen", 10000.0, new DateTime(2021, 01, 11));
            var no2 = new Employee("Ola Nordmann", 230_000.0);

            no1.Raise(25000);
            Console.WriteLine(no1.ToString());
            Console.WriteLine(no2.ToString());
        }
    }
}
