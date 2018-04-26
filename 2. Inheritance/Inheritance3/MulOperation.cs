namespace Inheritance3
{
    class MulOperation : AbstractOperation
    {
        public MulOperation(int arg1, int arg2) : base(arg1, arg2)
        {
        }

        public override int GetResult()
        {
            return (arg1 * arg2);
        }

        public override string ToString()
        {
            return (arg1 + "*" + arg2 + "=" + GetResult());
        }
    }
}