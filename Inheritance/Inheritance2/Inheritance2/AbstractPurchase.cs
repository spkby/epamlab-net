using System;

namespace Inheritance2
{
    abstract class AbstractPurchase : IComparable<AbstractPurchase>
    {
        public Commodity Commodity { get; }
        public int Count { get; }

        public AbstractPurchase()
        {
        }

        public AbstractPurchase(Commodity commodity, int count)
        {
            Commodity = commodity;
            Count = count;
        }

        public abstract int GetCost();

        protected int CalcCost()
        {
            return (Commodity.Price * Count);
        }

        public override string ToString()
        {
            return (Commodity + ";" + Count);
        }

        public int CompareTo(AbstractPurchase other)
        {
            return (other.GetCost() - GetCost());
        }
    }
}