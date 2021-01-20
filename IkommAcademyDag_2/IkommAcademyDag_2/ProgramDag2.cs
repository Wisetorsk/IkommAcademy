using IKOMM.Library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IkommAcademyDag_2
{
    class ProgramDag2
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();

            List<int> oddNumbers = new List<int>(100);
            Console.WriteLine(oddNumbers.Count);
        }

        private static void Task2()
        {
            Person person1 = new Person("Joe", "Biden", 78);
            Person person2 = new Person("Donald", "Trump", 74);

            Console.WriteLine(person1.DisplayName());
            Console.WriteLine(person2.DisplayName());
        }

        private static void Task1()
        {
            //string[] cityNames = new string[] { "Oslo" , "Lillehammer", "Bergen" };
            bool running = false;
            do
            {
                Console.Write("Enter something: ");
                string userInput = Console.ReadLine();
                //userInput.Split(' ');
                Console.WriteLine(userInput);
                running = !(userInput.Contains("Oslo") ||  // Hard Coded method
                            userInput.Contains("Lillehammer") ||
                            userInput.Contains("Bergen"));

            } while (running);
        }
    }
}
