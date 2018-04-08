using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
	class Commodity
	{
		public string Name { get; set; }
		public int Price { get; set; }

		public Commodity()
		{
		}

		public Commodity(string name, int price)
		{
			Name = name;
			Price = price;
		}

		public override string ToString()
		{
			return (Name + ";" + Price);
		}
	}
}
