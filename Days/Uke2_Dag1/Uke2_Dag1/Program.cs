using System;
using System.Collections.Generic;

namespace Uke2_Dag1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Vehicle>();
            cars.Add(new Vehicle("Some werid thing"));
            cars.Add(new Sedan("sedan1"));
            cars.Add(new Truck("truck"));
            cars.Add(new GermanSedan("sedan1"));

            var separator = new string('=', Console.WindowWidth);
            var interLine = new string('.', Console.WindowWidth);

            foreach (var car in cars)
            {
                Console.WriteLine(separator);
                Console.WriteLine(car);
                Console.WriteLine(interLine);
                Console.WriteLine($"Starting speed: {car.Speed}");
                car.SpeedUp();
                Console.WriteLine($"I've sped up, I'm now moving with speed: {car.Speed} km/h!");
                Console.WriteLine();
            }

        }
    }
}
