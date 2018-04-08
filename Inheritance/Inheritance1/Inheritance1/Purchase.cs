using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
	class Purchase
	{

		public string ProductName { get; set; }
		public int Price { get; set; }
		public int Count { get; set; }

		public Purchase() { }

		public Purchase(string productname, int price, int count)
		{
			ProductName = productname;
			Price = price;
			Count = count;
		}

		public virtual int GetCost()
		{
			return (Price * Count);
		}

		protected virtual string PurchaseToString()
		{
			return (ProductName + ";" + Price + ";" + Count);
		}


		public override string ToString()
		{
			return (PurchaseToString() + ";" + GetCost());
		}

		public override bool Equals(object obj)
		{
			var purchase = obj as Purchase;
			return (purchase != null &&
						 ProductName == purchase.ProductName &&
						 Price == purchase.Price);
		}
	}
}
