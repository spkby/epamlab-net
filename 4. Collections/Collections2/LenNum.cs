namespace Collections2
{
    public class LenNum
    {
        public readonly int Len;
        public int Num { get; private set; }

        public LenNum(int len)
        {
            Len = len;
            Num = 1;
        }

        public void Increment()
        {
            Num++;
        }

        public override string ToString()
        {
            return (Len+";"+Num);
        }
    }
}