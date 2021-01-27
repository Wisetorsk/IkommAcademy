using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionDemo
{
    public class NeedMoreCoffeeException : Exception
    {
        public int HowMuchCoffeeNeeded { get; set; }
        public DateTime TimeStamp { get; } = DateTime.Now;
        public NeedMoreCoffeeException(string message) : base(message)
        {

        }
        public NeedMoreCoffeeException(string message, int howMuchCoffeeNeeded) : base(message)
        {
            HowMuchCoffeeNeeded = howMuchCoffeeNeeded;
        }
    }
}
