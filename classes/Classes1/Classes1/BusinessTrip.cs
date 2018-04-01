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
		public string Employee { get; set; }
		public int TransportationExpenses { get; set; }
		public int Days { get; set; }

		public BusinessTrip()
		{ }

		public BusinessTrip(string employee, int transportationExpenses, int days)
		{
			TransportationExpenses = transportationExpenses;
			Employee = employee;
			Days = days;
		}

		public int GetTotal()
		{
			return TransportationExpenses + Rate * Days;
		}

		public void Show()
		{
			Console.WriteLine("rate = " + Rate);
			Console.WriteLine("account = " + Employee);
			Console.WriteLine("transport = " + TransportationExpenses);
			Console.WriteLine("days = " + Days);
			Console.WriteLine("total = " + GetTotal());
		}

		public override String ToString()
		{
			return Rate + ";" + Employee + ";" + TransportationExpenses + ";" + Days + ";" + GetTotal();
		}
	}
}
