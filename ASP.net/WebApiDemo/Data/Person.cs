using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Data
{
    public class TestPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age => (Birthday is null) ? 0 : DateTime.Now.Year - Birthday.Value.Year;
        public DateTime? Birthday { get; set; } = null;
        public DateTime Consructed => DateTime.Now;

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast name: {LastName}\nBirthday: {Birthday}\nAge: {Age}\nConstructed: {Consructed}";
        }
    }
}
