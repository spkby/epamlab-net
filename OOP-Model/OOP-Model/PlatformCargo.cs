namespace OOP
{
    class PlatformCargo : Cargo
    {
        private const int MassPlatform = 0;

        private readonly int _weightCargo;

        public PlatformCargo(int weightCargo) : base(MassPlatform)
        {
            _weightCargo = weightCargo;
        }

        protected override double CalcWeight()
        {
            return _weightCargo;
        }

        protected override string FieldsToString()
        {
            return (base.FieldsToString() + ";" + _weightCargo);
        }
    }
}