using System;

namespace Inheritance3
{
    abstract class AbstractOperation : IComparable<AbstractOperation>
    {
        public int arg1 { get; }
        public int arg2 { get; }

        public AbstractOperation(int arg1, int arg2)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
        }

        public abstract int GetResult();

        public override string ToString()
        {
            return (arg1 + ";" + arg2);
        }

        public int CompareTo(AbstractOperation other)
        {
            return (other.GetResult() - GetResult());
        }
    }
}