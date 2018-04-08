using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
	class PriceDiscountPurchase : AbstractPurchase
	{
		public PriceDiscountPurchase() : base()
		{	}

		public PriceDiscountPurchase(Commodity commodity, int count, int discountPrice) : base(commodity, count)
		{
			DiscountPrice = discountPrice;
		}

		public int DiscountPrice { get; set; }

		public override int GetCost()
		{
			return ((Commodity.Price - DiscountPrice) * Count);
		}

		public override string ToString()
		{
			return (base.ToString() + ";" + DiscountPrice);
		}

	}
}
