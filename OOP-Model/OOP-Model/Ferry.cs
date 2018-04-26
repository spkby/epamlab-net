using System;
using System.Collections.Generic;

namespace OOP
{
    class Ferry
    {
        private const int MaxCapacity = 100000;

        private readonly IWeightable[] _weights;

        public Ferry(IWeightable[] weights)
        {
            _weights = weights;
        }

        public bool IsOverloaded()
        {
            double totalWeight = 0;
            foreach (IWeightable weight in _weights)
            {
                totalWeight += weight.GetWeight();
            }

            return (totalWeight > MaxCapacity);
        }

        public void Show()
        {
            foreach (IWeightable weight in _weights)
            {
                Console.WriteLine(weight);
            }

            Console.WriteLine();
        }

        public void Sort(IComparer<IWeightable> comparer)
        {
            Array.Sort(_weights, comparer);
        }

        public void Sort()
        {
            Sort(new IWeightableComparer());
        }
    }
}