using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKOMM.Library
{
    public class Person
    {
        #region fields
        private int age;
        private string firstName;
        private string lastName;
        #endregion

        #region properties
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }
        #endregion

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string DisplayName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}


