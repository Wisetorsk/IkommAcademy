using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    interface Iitem
    {
        bool Borrowed();
        bool CanBeBorrowedBy(Member member);
        bool BorrowItemBu(Member member);
        void ReturnItem();
        string ToString();
    }
}
