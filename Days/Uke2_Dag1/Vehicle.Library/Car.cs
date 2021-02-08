using System;
using System.Collections.Generic;
using System.Text;

namespace Uke2_Dag1
{
    public class Vehicle : IVehicle
    {
        public double Speed { get; internal set; }
        protected int Wheels { get; set; }
        protected double Weight { get; set; }
        protected int Doors { get; set; }
        protected string sound;
        protected string carModel;
        internal double interval;
        internal Random r = new Random();

        public Vehicle(string model)
        {
            Speed = 0;
            Wheels = 4;
            Weight = 1000;
            sound = "honk";
            interval = 10;
            carModel = model;
        }

        public void Horn()
        {
            Console.WriteLine(sound);
        }

        public void SlowDown()
        {
            Speed -= interval;
        }

        public void SpeedUp()
        {
            Speed += interval;
        }

        public override string ToString()
        {
            return $"{sound}! I am a: {this.GetType().Name}, Model type: {this.carModel}\nI have {Doors} doors and i weigh {Weight} kg!";
        }
    }

    public class Sedan : Vehicle  {
        public Sedan(string model) : base(model)
        {
            sound = "honk";
            Doors = 4;
            Weight = 1000;
            interval = 15;
        }

    }

    public class GermanSedan : Sedan
    {
        public GermanSedan(string model) : base(model)
        {
            sound = "HÖNK";
            carModel = $"{model[0]}{r.Next(100,500)}i";
        }
    }

    public class Truck : Vehicle
    {
        public Truck(string model) : base(model)
        {
            sound = "HOOOOOOOOONK";
            Wheels = 16;
            Doors = 2;
            Weight = 2000;
            interval = 5;
        }
    }
}
