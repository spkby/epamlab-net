using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class TankCargo : Cargo
	{

		private readonly FluidMaterial fluid;
		private readonly int radius;
		private readonly int height;

		public TankCargo(int massTank, int radius, int height, FluidMaterial fluid) : base(massTank)
		{
			this.radius = radius;
			this.height = height;
			this.fluid = fluid;
		}

		protected override double CalcWeight()
		{
			return (Math.PI * radius * radius * height * fluid.GetDesity());
		}
	}
}
