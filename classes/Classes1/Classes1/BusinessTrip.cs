using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
	public class BusinessTrip
	{
		public const int Rate = 700;
		public string Account { get; set; }
		public int TransportationExpenses { get; set; }
		public int Days { get; set; }

		public BusinessTrip()
		{ }

		public BusinessTrip(string account, int transportationExpenses, int days)
		{
			TransportationExpenses = transportationExpenses;
			Account = account;
			Days = days;
		}

		public int GetTotal()
		{
			return (TransportationExpenses + Rate * Days);
		}

		public void Show()
		{
			Console.WriteLine("rate = " + Rate);
			Console.WriteLine("account = " + Account);
			Console.WriteLine("transport = " + TransportationExpenses);
			Console.WriteLine("days = " + Days);
			Console.WriteLine("total = " + GetTotal());
		}

		public override String ToString()
		{
			return (Rate + ";" + Account + ";" + TransportationExpenses + ";" + Days + ";" + GetTotal());
		}
	}
}
