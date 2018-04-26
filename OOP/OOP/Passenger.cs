namespace OOP
{
    class Passenger : IWeightable
    {
        private readonly string _name;
        private readonly int _mass;

        public Passenger(string name, int mass)
        {
            _name = name;
            _mass = mass;
        }

        public double GetWeight()
        {
            return _mass;
        }

        public override string ToString()
        {
            return (this.GetType().Name + ";" + _name + ";" + _mass);
        }
    }
}