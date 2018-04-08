using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
	class Program
	{
		static void Main(string[] args)
		{
			AbstractPurchase[] purchases = new AbstractPurchase[]
			{
				new TransportExpensesPurchase(new Commodity(null,0),0,0),
				new PriceDiscountPurchase(new Commodity(null,0),0,0),
				new PercentDiscountPurchase(new Commodity(null,0),0,0),
				new TransportExpensesPurchase(new Commodity(null,0),0,0),
				new PriceDiscountPurchase(new Commodity(null,0),0,0),
				new PercentDiscountPurchase(new Commodity(null,0),0,0)
			};

			PrintPurchases(purchases);

			Array.Sort(purchases);

			PrintPurchases(purchases);

			Console.Read();
		}

		private static void PrintPurchases(AbstractPurchase[] purchases)
		{
			foreach (var purchase in purchases)
			{
				Console.WriteLine(purchase);
			}
		}
	}
}
