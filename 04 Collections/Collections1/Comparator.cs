using System.Collections.Generic;

namespace Collections1
{
    public class Comparator : IComparer<Purchase>
    {
        private enum Equal
        {
            Equal,
            More
        }

        public int Compare(Purchase x, Purchase y)
        {
            var result = x.Name.CompareTo(y.Name);

            if (result != 0) return result;
            result = GetRank(x) - GetRank(y);
            return (result != 0 ? result : x.GetCost().CompareTo(y.GetCost()));
        }

        private static int GetRank(Purchase p)
        {
            return (IsPricePurchase(p) ? (int) Equal.More : (int) Equal.Equal);
        }

        private static bool IsPricePurchase(Purchase p)
        {
            return (p is PricePurchase);
        }
    }
}