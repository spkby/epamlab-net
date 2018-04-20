using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Passenger : IWeightable
	{
		private readonly string name;
		private readonly int mass;

		public Passenger(string name, int mass)
		{
			this.name = name;
			this.mass = mass;
		}
		
		public double GetWeight()
		{
			return mass;
		}

		public override string ToString()
		{
			return (this.GetType().Name + ";" + name + ";" + mass);
		}
	}
}
