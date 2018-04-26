namespace Inheritance3
{
    class AddOperation : AbstractOperation
    {
        public AddOperation(int arg1, int arg2) : base(arg1, arg2)
        {
        }

        public override int GetResult()
        {
            return (arg1 + arg2);
        }

        public override string ToString()
        {
            return (arg1 + "+" + arg2 + "=" + GetResult());
        }
    }
}