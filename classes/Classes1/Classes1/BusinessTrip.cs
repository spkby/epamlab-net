using System;

namespace Classes1
{
	public class BusinessTrip
	{
		public const int Rate = 700;
		public string Account { get; }
		public int TransportationExpenses { get; set; }
		public int Days { get; }

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
