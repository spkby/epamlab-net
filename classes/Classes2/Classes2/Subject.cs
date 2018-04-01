using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
	class Subject
	{
		public string Name { get; set; }
		public Material Material { get; set; }
		public double Volume { get; set; }

		public Subject()
		{	}

		public Subject(string name, Material material, double volume)
		{
			Name = name;
			Material = material;
			Volume = volume;
		}

		public double GetMass()
		{
			return Volume * Material.GetDensity();
		}

		public override string ToString()
		{
			return Name + ";" + Material + ";" + Volume + ";" + GetMass();
		}

	}
}
