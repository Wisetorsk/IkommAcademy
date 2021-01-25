using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySystem
{
    public class Member
    {
        // Properties.
        public string Name { get; }
        public int Age { get; }
        public int NumberItemsBorrowed { get; private set; } = 0;

        // Constructor.
        public Member(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // string representation.
        public override string ToString()
        {
            return $"{Name}, aged {Age}, has {NumberItemsBorrowed} items(s) on loan.";
        }

        // Business methods.
        public void BorrowedItem()
        {
            NumberItemsBorrowed++;
        }

        public void ReturnedItem()
        {
            NumberItemsBorrowed--;
        }
    }
}
