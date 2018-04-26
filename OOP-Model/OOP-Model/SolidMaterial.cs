namespace OOP
{
    class SolidMaterial : Material
    {
        private readonly double _ratio;

        public SolidMaterial(string name, int desity, double ratio) : base(name, desity)
        {
            _ratio = ratio;
        }

        public double GetRatio()
        {
            return _ratio;
        }
    }
}