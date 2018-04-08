using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
	class PriceDiscountPurchase : Purchase
	{
		public PriceDiscountPurchase() : base()
		{	}

		public PriceDiscountPurchase(string productName, int price, int count, int discountPrice) : base(productName, price, count)
		{
			DiscountPrice = discountPrice;
		}

		public int DiscountPrice { get; set; }

		public override int GetCost()
		{
			return ((Price - DiscountPrice) * Count);
		}

		public override string ToString()
		{
			return (base.ToString() + ";" + DiscountPrice);
		}

	}
}
