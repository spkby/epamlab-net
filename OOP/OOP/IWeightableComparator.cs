using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class IWeightableComparer : IComparer<IWeightable>
	{
		enum Weightable
		{
			Passenger,
			ContainerCargo,
			PlatformCargo,
			TankCargo
		};

		public int Compare(IWeightable x, IWeightable y)
		{
			return (((int)Enum.Parse(typeof(Weightable), x.GetType().Name)) - 
				((int)Enum.Parse(typeof(Weightable), y.GetType().Name)));
		}
	}
}
