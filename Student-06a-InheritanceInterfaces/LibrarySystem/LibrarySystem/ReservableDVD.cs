using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibrarySystem.Item;

namespace LibrarySystem
{
    class ReservableDVD : DVD, IReservable
    {
        public Member[] ReservedTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Reserved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ReservableDVD(string title, int playTime, Classification rating) : base(title, playTime, rating)
        {
        }


        public bool CanBeReservedFor(Member member)
        {
            throw new NotImplementedException();
        }

        public bool ReserveItemFor(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
