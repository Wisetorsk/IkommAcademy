using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    interface IReservable
    {
        bool Reserved();
        bool CanBeReservedFor(Member member);
        bool ReserveItemFor(Member member);
    }
}
