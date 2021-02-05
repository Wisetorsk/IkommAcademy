using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySite.Models;

namespace MySite.Data
{
    public class DbInitializer
    {

        public static void Initialize(StudentContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return; //Db set
            }

            var students = new Student[]
            {
                new Student{FirstName="Marius", LastName="Kristiansen", Birthday=DateTime.Parse("1992-04-13")},
                new Student{FirstName="Kristoffer", LastName="Kristoffersson", Birthday=DateTime.Parse("1990-10-21")},
                new Student{FirstName="Ola", LastName="Nordmann", Birthday=DateTime.Parse("1992-04-13")},
                new Student{FirstName="Truls", LastName="Askeladd", Birthday=DateTime.Parse("1841-02-22")},
                new Student{FirstName="Per", LastName="Askeladd", Birthday=DateTime.Parse("1839-06-11")},
                new Student{FirstName="Pål", LastName="Askeladd", Birthday=DateTime.Parse("1844-10-08")}
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var hobbies = new Hobby[]
            {
                new Hobby{HobbyID=0001, HobbyName="Electronics Design"},
                new Hobby{HobbyID=0002, HobbyName="Troll Slaying"},
                new Hobby{HobbyID=0003, HobbyName="Computers"},
                new Hobby{HobbyID=0004, HobbyName="Video Games"},
                new Hobby{HobbyID=0005, HobbyName="Being Useless"}, //"'hobbies'"
                new Hobby{HobbyID=0006, HobbyName="Overconfidence"}, //"'hobbies'"
            };

            foreach (Hobby h in hobbies)
            {
                context.Hobbies.Add(h);
            }
            context.SaveChanges();
        }
    }
}
