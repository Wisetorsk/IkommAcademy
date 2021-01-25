using static LibrarySystem.Item;
using System;
using System.Linq;
using System.Collections.Generic;

namespace LibrarySystem
{
    class Program
    {

        //private static IReservable[4] testReserable;
        static void Main(string[] args)
        {

            // I should try to convert this to proper unit testing..
            var tests = new List<bool>() {
                Tests.TestBookCanBorrow(),
                Tests.TestReservableBookCanReserve(),
                Tests.TestDVDCanReserve(),
                Tests.TestReserveUnborrowedBook(),
                Tests.TestReserveBorrowedBook(),
                Tests.TestReservable()
                    };
            foreach (var result in tests)
            {
                if (!result) Console.WriteLine($"A test failed!");
            }


            var items = new Item[] {
            new Book("This is a childrens book", "Childrens author", 654321987, ItemGenre.Children),
            new Book("This is a Fiction Book", "Somebody Somename", 1234567891, ItemGenre.Fiction),
            new Book("This is a Non fiction Book", "Somebody Somename", 1234567891, ItemGenre.NonFiction),
            
        }; //IItem Can also be used.
            items.ToList().ForEach(Console.WriteLine);
            Member testChild = new Member("child_1", 9);
            Member testAdult = new Member("adult_1", 45);
            //items[5].BorrowItemBy(testChild);
            Console.WriteLine(items[1]); // At this point doe date back is null since the book hasn't been loaned out yet
            items[1].BorrowItemBy(testAdult);
            Console.WriteLine(items[1].DateDueBack);
            Console.WriteLine(items[1].BorrowItemBy(testChild) ? "I just loadned it out!?" : "Already loaned out");
            Console.WriteLine(items[1]);

            Console.WriteLine(new string('*', Console.WindowWidth));
            Console.WriteLine(new string('-', Console.WindowWidth/2 - 3) + "Tests!" + new string('-', Console.WindowWidth / 2 - 3));
            Console.WriteLine(new string('*', Console.WindowWidth));


            Console.ReadLine();
        }




    }
}
