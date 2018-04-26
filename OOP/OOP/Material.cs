namespace OOP
{
    abstract class Material
    {
        private readonly string _name;
        private readonly int _desity;

        public Material(string name, int desity)
        {
            _name = name;
            _desity = desity;
        }

        public int GetDesity()
        {
            return _desity;
        }

        public override string ToString()
        {
            return (_name + ";" + _desity);
        }
    }
}