using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
	class PercentDiscountPurchase : AbstractPurchase
	{
		public PercentDiscountPurchase() : base()
		{ }

		public PercentDiscountPurchase(Commodity commodity, int count, int discountPercent) : base(commodity, count)
		{
			DiscountPercent = discountPercent;
		}

		public const int DiscountCount = 0;
		public int DiscountPercent { get; set; }

		public override int GetCost()
		{
			int cost = CalcCost();
			if (Count > DiscountCount)
			{
				cost = (int)((double)cost * (1.0 - (double)DiscountPercent / 100.0));
			}
			return cost;
		}

		public override string ToString()
		{
			return (base.ToString() + ";" + DiscountPercent + ";" + DiscountCount);
		}

	}
}
