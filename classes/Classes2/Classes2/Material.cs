using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
	class Material
	{
		public readonly string Name;
		public readonly double Density;

		public Material() : this(null, 0.0) { }

		public Material(string name, double density)
		{
			Name = name;
			Density = density;
		}

		public double GetDensity()
		{
			return Density;
		}

		public String GetName()
		{
			return Name;
		}

		
		public override string ToString()
		{
			return Name + ";" + Density;
		}
	}
}
