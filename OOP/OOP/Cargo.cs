namespace OOP
{
    abstract class Cargo : IWeightable
    {
        private readonly int _massCargo;

        public Cargo(int mass)
        {
            _massCargo = mass;
        }

        protected abstract double CalcWeight();

        protected virtual string FieldsToString()
        {
            return (GetType().Name + ";" + _massCargo);
        }

        public override string ToString()
        {
            return (FieldsToString() + ";" + CalcWeight());
        }

        public double GetWeight()
        {
            return (CalcWeight() + _massCargo);
        }
    }
}