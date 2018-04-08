using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
	class Program
	{
		static void Main(string[] args)
		{

			Purchase[] purchases = new Purchase[]
			{
				new Purchase(null,0,0),
				new PriceDiscountPurchase(null,0,0,0),
				new PercentDiscountPurchase(null,0,0,0),
				new Purchase(null,0,0),
				new PriceDiscountPurchase(null,0,0,0),
				new PercentDiscountPurchase(null,0,0,0)
			};

			Purchase maxP = purchases[0];
			bool areEquals = true;

			foreach (var purchase in purchases)
			{
				Console.WriteLine(purchase);

				if (areEquals)
				{
					areEquals = purchase.Equals(purchases[0]);
				}

				if(maxP.GetCost() < purchase.GetCost())
				{
					maxP = purchase;
				}
			}

			Console.WriteLine(maxP);
			if (areEquals)
			{
				Console.WriteLine("All purchase are equals");
			}

			Console.Read();
		}
	}
}
