namespace Inheritance2
{
	class Commodity
	{
		public string Name { get; }
		public int Price { get; }

		public Commodity(string name, int price)
		{
			Name = name;
			Price = price;
		}

		public override string ToString()
		{
			return (Name + ";" + Price);
		}
	}
}
