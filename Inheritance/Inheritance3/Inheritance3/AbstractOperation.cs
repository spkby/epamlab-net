using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
	abstract class AbstractOperation : IComparable<AbstractOperation>
	{

		public int arg1 { get; set; }

		public int arg2 { get; set; }

		public AbstractOperation()
		{
		}

		public AbstractOperation(int arg1, int arg2)
		{
			this.arg1 = arg1;
			this.arg2 = arg2;
		}

		public abstract int GetResult();

		public override string ToString()
		{
			return (arg1+";"+arg2);
		}

		public int CompareTo(AbstractOperation other)
		{
			return (other.GetResult()- GetResult());
		}
	}
}
