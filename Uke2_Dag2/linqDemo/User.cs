using System;
using System.Collections.Generic;
using System.Text;

namespace linqDemo
{
    class User
    {
        private static Random rand = new Random();
        public int Age { get; } = rand.Next(99);
        public string Name { get; set; }
        public decimal Balance { get; private set; } = (decimal)rand.Next(10000);
        public int Transactions { get; private set; } = rand.Next(20);

        public static List<User> GetUsers()
        {
            return new List<User> {
                new User { Name = "User 1" }, //Didn't know it was allowed to directly access the properties at construction! Neat!
                new User { Name = "User 2" },
                new User { Name = "User 3" },
                new User { Name = "User 4" }
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\tBalance: NOK {Balance:c}\tTransactions: {Transactions}";
        }
    }
}
