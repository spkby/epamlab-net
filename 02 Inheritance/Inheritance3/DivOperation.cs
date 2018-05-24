namespace Inheritance3
{
    class DivOperation : AbstractOperation
    {
        public DivOperation(int arg1, int arg2) : base(arg1, arg2)
        {
        }

        public override int GetResult()
        {
            return (arg1 / arg2);
        }

        public override string ToString()
        {
            return (arg1 + "/" + arg2 + "=" + GetResult());
        }
    }
}