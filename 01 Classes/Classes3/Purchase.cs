using System;

namespace Classes3
{
    enum Day
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    };

    class Purchase : IComparable<Purchase>
    {
        private const int Price = 0;
        private string Product { get; }
        private int Number { get; }
        private double Percent { get; }
        public Day WeekDay { get; }

        public Purchase(string product, int number, double percent, Day weekDay)
        {
            Product = product;
            Number = number;
            Percent = percent;
            WeekDay = weekDay;
        }

        public int GetCost()
        {
            return ((int) (Price * Number * ((100.0 - Percent) / 100.0)));
        }

        public override string ToString()
        {
            return (Product + ";" + Number + ";" + Percent + ";" + WeekDay + ";" + GetCost());
        }

        public int CompareTo(Purchase purchase)
        {
            return (GetCost() - purchase.GetCost());
        }
    }
}