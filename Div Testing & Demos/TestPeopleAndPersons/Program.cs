using AcademyBot.Objects;
using IKOMM.CustomLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestPeopleAndPersons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //TestPopulation();
            //TestInterpolator();
            //FizzBuzz(100);

            var weights = new List<double> { .01, .1, 1, .5, .8, .3 };
            var r = new Random();
            var w = weights.Select(i => i * r.NextDouble()).ToList();
            w.ForEach(i => Console.Write($"{i:f3} "));


        }

        private static void TestInterpolator()
        {
            var goblin =
@"                             
             ,      ,        
            /(.-  -.)\       
        |\  \/      \/  /|   
        | \ / =.  .= \ / |   
        \( \   o\/o   / )/   
         \_, '-/  \-' ,_/    
           /   \__/   \      
           \ \__/\__/ /      
         ___\ \|--|/ /___    
       /`    \      /    `\  
      /       '----'       \  
";
            var text = @"
                        88          88 88              
                        88          88                 
                        88          88                 
 ,adPPYb,d8  ,adPPYba,  88,dPPYba,  88 88 8b,dPPYba,   
a8     `Y88 a8       8a 88P'     8a 88 88 88P'   ` 8a  
8b       88 8b       d8 88       d8 88 88 88       88  
 8a,   ,d88  8a,   ,a8  88b,   ,a8  88 88 88       88  
 ` YbbdP Y8  ` YbbdP '  8Y Ybbd8 '  88 88 88       88  
 aa,    ,88                                            
   Y8bbdP";
            //Console.WriteLine(goblin);
            var testText = "aaaaa\nbbbbb\nccccc\nddddd"; //This works
            var testVerbatim = @"aaaaa
bbbbb
ccccc
ddddd";
            Interpolator.Interpolate(testText, testText).ForEach(Console.WriteLine);
            Interpolator.Interpolate(testVerbatim, testVerbatim).ForEach(Console.WriteLine); // Verbatim strings break it...

            testText.Split('\n').Zip(testText.Split('\n'), (i, j) => $"{i}\t{j}").ToList().ForEach(Console.WriteLine);

            //lines.ForEach(Console.WriteLine);
        }

        private static void TestPopulation()
        {
            var pop = new Population();
            pop.LoadPeople(); // Loads saved persons
            pop.MakePerson(998877665544, "123,456,789", false);
            pop.People.ForEach(Console.WriteLine);
            pop.SavePeople(); //Works now
            //Console.WriteLine(pop.GetPerson(998877665544));
        }

        private static void Task1()
        {
            var r = new Random();
            var numbers = Enumerable.Range(0, 6).Select(i => r.Next(99)).ToList();
            numbers.ForEach(Console.WriteLine);
            numbers.Sort();
            Console.WriteLine("\nAscending: ");
            numbers.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("\nDescending: ");
            numbers.OrderByDescending(i => i).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("\nSquares: ");
            numbers.Select(i => i * i).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("\nOdd numbers: ");
            numbers.Where(i => i % 2 == 1).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("\nResult:");
            Console.WriteLine($"Sum: {numbers.Sum()}\tAverage: {numbers.Average()}\tMax: {numbers.Max()}\tMin: {numbers.Min()}");
        }

        private static void FizzBuzz(int len)
        {
            Enumerable.Range(1, len).Select(i => (i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 || i.ToString().Contains("3")? "Fizz" : i % 5 == 0 || i.ToString().Contains("5") ? "Buzz" : i.ToString())).ToList().ForEach(Console.WriteLine);
        }
    }
}
