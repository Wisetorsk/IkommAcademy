using static LibrarySystem.Item;
using System;
using System.Linq;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var testChild = new Member("child_1", 10);
            var testAdult = new Member("adult_1", 50);
            var items = new Item[] {
            new Book("This is a childrens book", "Childrens author", 654321987, ItemGenre.Children),
            new Book("This is a Fiction Book", "Somebody Somename", 1234567891, ItemGenre.Fiction),
            new Book("This is a Non fiction Book", "Somebody Somename", 1234567891, ItemGenre.NonFiction),
            new DVD("Universal DVD", 90, Classification.Universal),
            new DVD("Youth DVD", 120, Classification.Youth),
            new DVD("Adult DVD", 110, Classification.Adult)
        }; //IItem Can also be used.
            items.ToList().ForEach(Console.WriteLine);

            //items[5].BorrowItemBy(testChild);
            Console.WriteLine("Can this tiem be loaned out to: \n" + testChild);
            Console.WriteLine(items[5].BorrowItemBy(testChild) ? "Yes, you can borrow it": "No, you are too young"); //Can test child borrow this dvd with adult classification
            Console.WriteLine(items[1]); // At this point doe date back is null since the book hasn't been loaned out yet
            items[1].BorrowItemBy(testAdult);
            Console.WriteLine(items[1].DateDueBack);
            Console.WriteLine(items[1].BorrowItemBy(testChild) ? "I just loadned it out!?" : "Already loaned out");
            Console.WriteLine(items[1]);

            Console.ReadLine();
        }
    }
}
