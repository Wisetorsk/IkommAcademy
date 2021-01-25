using System;

namespace LibrarySystem
{
    public abstract partial class Item
    {
        public class DVD : Item
        {
            private int PlayTime { get; set; }
            private Classification ?Rating { get; set; } = null;
            internal override DateTime ?DateDueBack { get => DateBorrowed?.AddDays(7); }

            public DVD(string title, int playTime, Classification rating) : base(title)
            {
                PlayTime = playTime;
                Rating = rating;

            }

            public override bool CanBeBorrowedBy(Member member)
            {
                if (Rating == Classification.Adult && member.Age < 18) return false;
                if (Rating == Classification.Youth && member.Age < 12) return false;
                return true;
            }

            public override string ToString()
            {
                return $"This is a {this.GetType().Name}\nTitle: {Title}\nRating: {Rating.ToString()}\nPlaying time: {PlayTime}\n{base.ToString()}";
            }
        }
    }
}
