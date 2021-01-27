using System;
using System.Collections.Generic;
using System.Linq;

namespace linqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            PrintSeparator();
            Task2();
            PrintSeparator();
            Task3();
        }

        private static void Task3()
        {
            
        }

        private static void Task1()
        {
            var r = new Random();
            var years = Enumerable.Range(1, 6).Select(i => r.Next(99));

            years = years.ToList(); // "To avoid Deferred execution of r.Next() every time years is evaluated
            Console.WriteLine("All the random lottery numbers: ");
            years.ToList().ForEach(Console.WriteLine); // Output all numbers

            Console.WriteLine("\nSorted descending: ");
            var yearsSorted = years.OrderByDescending(i => i);
            yearsSorted.ToList().ForEach(Console.WriteLine); // Output all numbers sorted ascending

            Console.WriteLine("\nAll the squares of the unsorted list: ");
            years.Select(i => i * i).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\nAll the odd numbers: ");
            years.Where(i => i % 2 == 1).ToList().ForEach(Console.WriteLine);

            Console.WriteLine($"\n\nSum: {years.Sum()}\nAverage: {years.Average()}\nMaximum: {years.Max()}\nMinimum: {years.Min()}");
        }

        private static void Task2()
        {
            var users = User.GetUsers();
            users.ForEach(Console.WriteLine);

            var selection = users.Select(i => $"UserName: {i.Name}\tBalance: {i.Balance:c}");
            selection.ToList().ForEach(Console.WriteLine);

            var positiveMoreThanTen = users.Where(i => i.Balance >= 0 && i.Transactions < 10);
            positiveMoreThanTen.ToList().ForEach(Console.WriteLine);
        }

        private static void PrintSeparator()
        {
            Console.WriteLine('\n' + new string('=', Console.WindowWidth) + '\n');
        }
    }
}
