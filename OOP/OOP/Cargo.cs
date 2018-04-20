using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	abstract class Cargo : IWeightable
	{
		private readonly int massCargo;

		public Cargo(int mass)
		{
			massCargo = mass;
		}

		protected abstract double CalcWeight();

		protected virtual string FieldsToString()
		{
			return massCargo.ToString();
		}

		public override string ToString()
		{
			return (FieldsToString() + ";" + CalcWeight());
		}

		public double GetWeight()
		{
			return (CalcWeight() + massCargo);
		}

	}


}
