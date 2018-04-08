using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
	abstract class AbstractPurchase : IComparable<AbstractPurchase>
	{
		public Commodity Commodity { get; set; }
		public int Count { get; set; }

		public AbstractPurchase()
		{
		}

		public AbstractPurchase(Commodity commodity, int count)
		{
			Commodity = commodity;
			Count = count;
		}

		public abstract int GetCost();

		protected virtual string PurchaseToString()
		{
			return Commodity + ";" + Count;
		}

		protected int CalcCost()
		{
			return (Commodity.Price * Count);
		}

		public override string ToString()
		{
			return (PurchaseToString()+";"+GetCost());
		}

		public int CompareTo(AbstractPurchase other)
		{
			return (other.GetCost()- GetCost());
		}
	}
}
