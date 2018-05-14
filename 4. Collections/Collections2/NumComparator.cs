using System.Collections.Generic;

namespace Collections2
{
    public class NumLenComparator : IComparer<LenNum>
    {
        public int Compare(LenNum x, LenNum y)
        {
            return y.Num - x.Num;
        }
    }
}