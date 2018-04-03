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
			Material steel = new Material("Steel", 7850.0);

			Subject wire = new Subject("Wire", steel, 0.03);

			Console.Write("Subject: ");
			Console.WriteLine(wire);

			Material cooper = new Material("Cooper", 8500.0);
			wire.Material = cooper;

			Console.WriteLine("The wire mass {0:F} kg.", wire.GetMass());

			Console.Read();
		}
	}
}
