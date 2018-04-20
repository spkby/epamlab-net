using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	abstract class Material
	{
		private readonly string Name;
    private readonly int Desity;

		public Material(string name, int desity)
		{
			Name = name;
			Desity = desity;
		}

		public string GetName()
		{
			return Name;
		}

		public int GetDesity()
		{
			return Desity;
		}

		public override string ToString()
		{
			return (Name + ";" + Desity);
		}
	}
}
