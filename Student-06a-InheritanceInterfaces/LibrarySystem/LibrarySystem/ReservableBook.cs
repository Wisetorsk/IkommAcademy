using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibrarySystem.Item;

namespace LibrarySystem
{
    public class ReservableBook : Book, IReservable
    {
        private bool reserved;
        public Member ReservedTo { get; set; } = null;
        public bool Reserved { get { return !(ReservedTo is null); } set { reserved = value;  } }
        public ReservableBook(string title, string author, int isbn, ItemGenre genre) : base(title, author, isbn, genre)
        {

        }

        public bool CanBeReservedFor(Member member)
        {
            return (CanBeBorrowedBy(member)); //Has to check wether the book is already reserved too!! Isn't it better to do this in the control.
        }

        public bool ReserveItemFor(Member member)
        {
            if (!Reserved && CurrentBorrower is null && CanBeReservedFor(member)) 
            {
                ReservedTo = member;
                return true;
            };
            return false;
        }

        public override void ReturnItem()
        {
            base.ReturnItem();
            if (Reserved)
            {
                CurrentBorrower = ReservedTo;
                ReservedTo = null;
            }
        }
    }
}
