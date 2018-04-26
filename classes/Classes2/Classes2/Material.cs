namespace Classes2
{
    class Material
    {
        private readonly string _name;
        private readonly double _density;

        public Material(string name, double density)
        {
            _name = name;
            _density = density;
        }

        public double GetDensity()
        {
            return _density;
        }

        public override string ToString()
        {
            return (_name + ";" + _density);
        }
    }
}