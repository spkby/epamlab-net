using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
	class Program
	{
		static void Main(string[] args)
		{
			Purchase[] purchases = new Purchase[] {
				new Purchase("milk",5,2.5,Day.Mon),
				new Purchase("milk",6,5.0,Day.Fri),
				new Purchase("milk",3,2.3,Day.Wed),
				new Purchase("milk",6,1.2,Day.Mon),
				new Purchase("milk",7,0,Day.Tue),
			};

			OutPurchases(purchases);

			int totalCost = 0;
			int maxCost = 0;
			int day = 0;

			foreach (var purchase in purchases)
			{
				int cost = purchase.GetCost();
				if(maxCost < cost)
				{
					maxCost = cost;
					day = (int)purchase.WeekDay;
				}
				totalCost += cost;
			}

			Console.WriteLine("Mean cost {0} BYN", totalCost/purchases.Length);
			Console.WriteLine("Day with max cost {0}", (Day)day);

			Array.Sort(purchases);

			OutPurchases(purchases);

			Console.Read();

		}

		static void OutPurchases(Purchase[] purchases)
		{
			foreach (Purchase purchase in purchases)
			{
				Console.WriteLine(purchase);
			}
		}
	}
}
