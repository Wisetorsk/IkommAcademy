using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }

        public ICollection<Hobby> Hobbies { get; set; }
    }
}
