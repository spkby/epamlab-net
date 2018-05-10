using System;
using System.Collections.Generic;

namespace Collections1
{
    public class Comparator : IComparer<Purchase>
    {
        private enum Sign
        {
            Equal,
            More
        }

        public int Compare(Purchase x, Purchase y)
        {
            var result = x.Name.CompareTo(y.Name);

            if (result == 0) {
                result = GetRank(x) - GetRank(y);
                if (result == 0) {
                    result = x.GetCost().CompareTo(y.GetCost());
                }
            }
            return result;
        }

        private static int GetRank(Purchase p)
        {
            return (IsPricePurchase(p) ? (int) Sign.More : (int) Sign.Equal);
        }

        private static bool IsPricePurchase(Purchase p)
        {
            return p is PricePurchase;
        }
    }
}