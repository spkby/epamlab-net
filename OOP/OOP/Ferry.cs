using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Ferry
	{
		private const int maxCapacity = 100000;

		private readonly IWeightable[] weights;

		public Ferry(IWeightable[] weights)
		{
			this.weights = weights;
		}

		public bool IsOverloaded()
		{
			double totalWeight = 0;
			foreach (IWeightable weight in weights)
			{
				totalWeight += weight.GetWeight();
			}
			return (totalWeight > maxCapacity);
		}

		public void Show()
		{
			foreach (IWeightable weight in weights)
			{
				Console.WriteLine(weight);
			}
			Console.WriteLine();
		}

		public void Sort(IComparer<IWeightable> comparer)
		{
			Array.Sort(weights, comparer);
		}

		public void Sort()
		{
			Sort(new IWeightableComparer());
		}
	}
}
