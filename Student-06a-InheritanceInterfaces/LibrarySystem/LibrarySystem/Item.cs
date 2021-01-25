using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public abstract class Item : Iitem
    {
        private string Title { get; set; }
        private DateTime ?DateBorrowed { get; set; } = null;
        private Member CurrentBorrower { get; set; } = null;

        public bool Borrowed()
        {
            throw new NotImplementedException();
        }

        public bool BorrowItemBu(Member member)
        {
            throw new NotImplementedException();
        }

        public bool CanBeBorrowedBy(Member member)
        {
            throw new NotImplementedException();
        }

        public void ReturnItem()
        {
            throw new NotImplementedException();
        }
    }
}
