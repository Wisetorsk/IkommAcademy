using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibrarySystem.Item;
using static LibrarySystem.Member;

namespace LibrarySystem
{
    public static class Tests
    {
        private static Member testChild = new Member("child_1", 10);
        private static Member testYouth = new Member("youth_1", 14);
        private static Member testAdult = new Member("adult_1", 50);

        public static bool TestBookCanBorrow()
        {
            Item[] books = new Item[] {
                new Book("ReservableBook_1", "TestAuthor_1", 123456789, ItemGenre.Fiction),
                new Book("ReservableBook_2", "TestAuthor_2", 987654321, ItemGenre.NonFiction),
                new Book("ReservableBook_3", "TestAuthor_3", 111111111, ItemGenre.Children),
                new Book("ReservableBook_4", "TestAuthor_4", 222222222, ItemGenre.Fiction)
            };

            if (!books[0].CanBeBorrowedBy(testAdult)) return false;
            if (!books[1].CanBeBorrowedBy(testAdult)) return false;
            if (!books[3].CanBeBorrowedBy(testAdult)) return false;
            if (books[2].CanBeBorrowedBy(testAdult)) return false;

            foreach (var book in books) // Loop through all books and check they can be reserved for testChild.
            {
                if (!book.CanBeBorrowedBy(testChild)) return false;
            }
            return true; // All test portions passed
        }

        public static bool TestDVDCanReserve()
        {
            Item[] dvds = new Item[]
            {
                new DVD("Universal DVD", 90, Classification.Universal),
                new DVD("Youth DVD", 120, Classification.Youth),
                new DVD("Adult DVD", 110, Classification.Adult)
            };
            if (!dvds[0].CanBeBorrowedBy(testChild)) return false;
            if (dvds[1].CanBeBorrowedBy(testChild)) return false;
            if (dvds[2].CanBeBorrowedBy(testChild)) return false;

            if (!dvds[0].CanBeBorrowedBy(testYouth)) return false;
            if (!dvds[1].CanBeBorrowedBy(testYouth)) return false;
            if (dvds[2].CanBeBorrowedBy(testYouth)) return false;

            foreach (var dvd in dvds)
            {
                if (!dvd.CanBeBorrowedBy(testAdult)) return false;
            }
            return true;
        }

        public static bool TestReservableBookCanReserve()
        {
            IReservable[] rBooks = new IReservable[] {
                new ReservableBook("ReservableBook_1", "TestAuthor_1", 123456789, ItemGenre.Fiction),
                new ReservableBook("ReservableBook_2", "TestAuthor_2", 987654321, ItemGenre.NonFiction),
                new ReservableBook("ReservableBook_3", "TestAuthor_3", 111111111, ItemGenre.Children),
                new ReservableBook("ReservableBook_4", "TestAuthor_4", 222222222, ItemGenre.Fiction)
            };

            if (!rBooks[0].CanBeReservedFor(testAdult)) return false;
            if (!rBooks[1].CanBeReservedFor(testAdult)) return false;
            if (!rBooks[3].CanBeReservedFor(testAdult)) return false;
            if (rBooks[2].CanBeReservedFor(testAdult)) return false;

            foreach (var book in rBooks) // Loop through all books and check they can be reserved for testChild.
            {
                if (!book.CanBeReservedFor(testChild)) return false;
            }
            return true; // All test portions passed
        }

        public static bool TestReserveUnborrowedBook()
        {
            var testBook = new ReservableBook("TestBookTitle", "TestBookAuthor", 123456789, ItemGenre.Fiction);
            if (!testBook.ReserveItemFor(testAdult)) return false;
            return true;
        }

        public static bool TestReserveBorrowedBook()
        {
            var localTestAdult = new Member("Adult", 50);
            var localTestAdult2 = new Member("Adult_2", 45);
            var testBook = new ReservableBook("ReservableBook_1", "TestAuthor_1", 123456789, ItemGenre.Fiction);
            testBook.BorrowItemBy(localTestAdult);
            if (!testBook.ReserveItemFor(localTestAdult2)) return false;
            return true;
        }

        public static bool TestReservable()
        { // I'm pretty sure this is not what you meant be ex. 3 part 1...
            IReservable[] rBooks = new IReservable[] {
                new ReservableBook("ReservableBook_1", "TestAuthor_1", 123456789, ItemGenre.Fiction),
                new ReservableBook("ReservableBook_2", "TestAuthor_2", 987654321, ItemGenre.NonFiction),
                new ReservableBook("ReservableBook_3", "TestAuthor_3", 111111111, ItemGenre.Children),
                new ReservableBook("ReservableBook_4", "TestAuthor_4", 222222222, ItemGenre.Fiction)
            };

            foreach (var book in rBooks)
            {
                if (!(book is IReservable)) return false;
            }
            return true;
        }
    }
}
