using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class PlatformCargo : Cargo
	{
		private const int massPlatform = 0;

		private readonly int weightCargo;

		public PlatformCargo(int weightCargo) : base(massPlatform)
		{
			this.weightCargo = weightCargo;
		}

		protected override double CalcWeight()
		{
			return weightCargo;
		}

		protected override string FieldsToString()
		{
			return (base.FieldsToString() + ";" + weightCargo);
		}
	}
}
