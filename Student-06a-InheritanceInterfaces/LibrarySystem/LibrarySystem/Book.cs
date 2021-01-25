using System;

namespace LibrarySystem
{
    public abstract partial class Item
    {
        public class Book : Item
        {
            private string Author { get; set; }
            private int ISBN { get; set; }
            private ItemGenre ?Genre { get; set; } = null;
            internal override DateTime ?DateDueBack { get => DateBorrowed?.AddDays(28); }


            public Book(string title, string author, int isbn, ItemGenre genre) : base(title)
            {
                Author = author;
                ISBN = isbn;
                Genre = genre;
            }

            public override bool CanBeBorrowedBy(Member member)
            {
                if (Genre == ItemGenre.Children && member.Age > 16) return false;
                return true;
            }

            public override string ToString()
            {
                return $"This is a {this.GetType().Name}\nTitle: {Title}\nAuthor: {Author}\nGenre: {Genre.ToString()}\nISBN: {ISBN}\n{base.ToString()}";
            }
        }
    }
}
