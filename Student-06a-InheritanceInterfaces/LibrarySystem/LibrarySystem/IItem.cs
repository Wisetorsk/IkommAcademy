using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    interface IItem
    {
        bool Borrowed();
        bool CanBeBorrowedBy(Member member);
        bool BorrowItemBy(Member member);
        void ReturnItem();
        string ToString();
    }
}
