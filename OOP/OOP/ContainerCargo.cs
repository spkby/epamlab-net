using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class ContainerCargo : Cargo
	{
		private SolidMaterial material;
		private int widthContainer;
		private int heightContainer;
		private int lengthContainer;

		public ContainerCargo(int massContainer, int width, int height, int lenght, SolidMaterial material) : base(massContainer)
		{
			widthContainer = width;
			heightContainer = height;
			lengthContainer = lenght;
			this.material = material;
		}

		protected override string FieldsToString()
		{
			return (base.FieldsToString() + ";" + material + ";" + widthContainer + ";" + heightContainer + ";" + lengthContainer);
		}

		protected override double CalcWeight()
		{
			return (widthContainer * heightContainer * lengthContainer * material.GetDesity() * material.GetRatio());
		}
	}
}
