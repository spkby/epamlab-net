using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
	enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

	class Purchase : IComparable<Purchase>
	{
		public const string PropuctName = "Milk";
		public const int Price = 115;

		public string Product { get; set; }
		public int Number { get; set; }
		public double Percent { get; set; }
		public Day WeekDay { get; set; }

		public Purchase()
		{ }

		public Purchase(string product, int number, double percent, Day weekDay)
		{
			Product = product;
			Number = number;
			Percent = percent;
			WeekDay = weekDay;
		}

		public int GetCost()
		{
			return (int)(Price * Number * ((100.0 - Percent) / 100.0));
		}

		public override string ToString()
		{
			return Product + ";" + Number + ";" + Percent + ";" + WeekDay + ";" + GetCost();
		}

		public int CompareTo(Purchase purchase)
		{
			return Number - purchase.Number;
		}

	}
}
