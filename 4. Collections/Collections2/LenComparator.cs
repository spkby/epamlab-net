using System.Collections.Generic;

namespace Collections2
{
    public class LenComparator : IComparer<LenNum>
    {
        public int Compare(LenNum x, LenNum y)
        {
            return (x.Len - y.Len);
        }
    }
}