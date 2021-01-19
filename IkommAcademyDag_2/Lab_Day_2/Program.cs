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

            no1.AddSkill("Computers");
            no1.AddSkill("Testing");
            no1.AddSkill("This", "and this");
            no1.RemoveSkill("This");


            Console.WriteLine(no2.ToString());
            no2.UpdateUser();
            Console.WriteLine(new string('=', Console.WindowWidth));
            Console.WriteLine(no1.ToString());
            Console.WriteLine(no2.ToString());
        }
    }
}
