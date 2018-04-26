using System;

namespace OOP
{
    class TankCargo : Cargo
    {
        private readonly FluidMaterial _fluid;
        private readonly int _radius;
        private readonly int _height;

        public TankCargo(int massTank, int radius, int height, FluidMaterial fluid) : base(massTank)
        {
            _radius = radius;
            _height = height;
            _fluid = fluid;
        }

        protected override double CalcWeight()
        {
            return (Math.PI * _radius * _radius * _height * _fluid.GetDesity());
        }
    }
}