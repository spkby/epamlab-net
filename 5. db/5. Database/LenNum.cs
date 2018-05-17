namespace Database
{
    public class LenNum
    {
        public readonly int Len;
        public readonly int Num;
        
        public LenNum(int len, int num)
        {
            Len = len;
            Num = num;
        }

        public override string ToString()
        {
            return (Len+";"+Num);
        }
    }
}