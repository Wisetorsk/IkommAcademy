using System;

namespace LibrarySystem
{
    public abstract partial class Item : IItem
    {
        private string Title { get; set; }
        private DateTime ?DateBorrowed { get; set; } = null;
        internal Member CurrentBorrower { get; set; } = null;
        internal abstract DateTime ?DateDueBack { get; }

        public Item(string title)
        {
            Title = title;
        }

        public bool Borrowed()
        {
            return (CurrentBorrower != null);
        }

        public virtual bool CanBeBorrowedBy(Member member)
        {
            return true;
        }

        public bool BorrowItemBy(Member member)
        {
            if (CurrentBorrower != null) return false; // If the item has a current borrorwer, return false.
            if (CanBeBorrowedBy(member)) 
            {
                CurrentBorrower = member;
                DateBorrowed = DateTime.Now;
                member.BorrowedItem();
                return true;
            }
            return false;
        }

        public void ReturnItem()
        {
            CurrentBorrower.ReturnedItem();
            CurrentBorrower = null;
            DateBorrowed = null;
        }

        public override string ToString()
        {
            return $"Borrowable: {(CurrentBorrower == null ? "Yes!" : $"No, currently loaned out to {CurrentBorrower}")}\n{new string('*', Console.WindowWidth)}\n";
        }
    }
}
