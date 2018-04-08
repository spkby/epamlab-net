using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
	class PercentDiscountPurchase : Purchase
	{
		public PercentDiscountPurchase() : base()
		{ }

		public PercentDiscountPurchase(string productName, int price, int count, int discountPercent) : base(productName, price, count)
		{
			DiscountPercent = discountPercent;
		}

		public const int DiscountCount = 0;
		public int DiscountPercent { get; set; }

		public override int GetCost()
		{
			int cost = base.GetCost();
			if (base.Count > DiscountCount)
			{
				cost = (int)((double)cost * (1.0 - (double)DiscountPercent / 100.0));
			}
			return cost;
		}

		protected override string PurchaseToString()
		{
			return (base.PurchaseToString() + ";" + DiscountPercent + ";" + DiscountCount);
		}

	}
}
