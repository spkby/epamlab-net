using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
	class TransportExpensesPurchase : AbstractPurchase
	{
		public TransportExpensesPurchase() : base()
		{ }

		public TransportExpensesPurchase(Commodity commodity, int count, int transportExpenses) : base(commodity, count)
		{
			TransportExpenses = transportExpenses;
		}

		public int TransportExpenses { get; set; }

		public override int GetCost()
		{
			return (CalcCost() + TransportExpenses);
		}

		public override string ToString()
		{
			return (base.ToString() + ";" + TransportExpenses);
		}
	}
}
