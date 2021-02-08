using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Data
{
    public class People
    {
    public List<TestPerson> Students => new List<TestPerson>{
        new TestPerson { FirstName = "Marius", LastName = "Kristiansen", Birthday =  DateTime.Parse("1992-04-13")},
        new TestPerson { FirstName = "Daniel", LastName = "Kristiansen", Birthday =  DateTime.Parse("1989-10-20")},
        new TestPerson { FirstName = "Test", LastName = "Person", Birthday = DateTime.Parse("1981-01-01")},
        new TestPerson { FirstName = "Old", LastName = "Man", Birthday = DateTime.Parse("1819-05-17")}
        };
    }
 }
