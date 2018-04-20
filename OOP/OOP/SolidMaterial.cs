using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class SolidMaterial : Material
	{
		private readonly double ratio;

		public SolidMaterial(string name, int desity, double ratio) : base(name, desity)
		{
			this.ratio = ratio;
		}

		public double GetRatio()
		{
			return ratio;
		}
	}
}
