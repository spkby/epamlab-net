using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
	class Program
	{
		static void Main(string[] args)
		{
			Material STEEL = new Material("Steel", 7850.0);

			Subject wire = new Subject("Wire", STEEL, 0.03);

			Console.Write("Subject: ");
			Console.WriteLine(wire);

			Material COOPER = new Material("Cooper", 8500.0);
			wire.Material = COOPER;

			Console.WriteLine("The wire mass {0:F} kg.", wire.GetMass());

			Console.Read();
		}
	}
}
