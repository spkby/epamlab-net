using System;

namespace Collections2
{
    public class LenNum : IComparable<LenNum>
    {
        public readonly int Len;
        public int Num { get; private set; }

        public LenNum(int len)
        {
            Len = len;
            Num = 1;
        }

        public void IncNum()
        {
            Num++;
        }

        public int CompareTo(LenNum other)
        {
            return (Len - other.Len);
        }

        public override string ToString()
        {
            return (Len+";"+Num);
        }
    }
}