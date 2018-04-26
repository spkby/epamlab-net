namespace OOP
{
    class ContainerCargo : Cargo
    {
        private readonly SolidMaterial _material;
        private readonly int _widthContainer;
        private readonly int _heightContainer;
        private readonly int _lengthContainer;

        public ContainerCargo(int massContainer, int width, int height, int lenght, SolidMaterial material) : base(
            massContainer)
        {
            _widthContainer = width;
            _heightContainer = height;
            _lengthContainer = lenght;
            _material = material;
        }

        protected override string FieldsToString()
        {
            return (base.FieldsToString() + ";" + _material + ";" + _widthContainer + ";" + _heightContainer + ";" +
                    _lengthContainer);
        }

        protected override double CalcWeight()
        {
            return (_widthContainer * _heightContainer * _lengthContainer * _material.GetDesity() *
                    _material.GetRatio());
        }
    }
}