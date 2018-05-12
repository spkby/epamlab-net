using System.Collections.Generic;

namespace Collections2
{
    public class NumLenComparator : IComparer<LenNum>
    {
        public int Compare(LenNum x, LenNum y)
        {
            var result = y.Num - x.Num;
            return (result != 0 ? result : x.Len - y.Len);
        }
    }
}