namespace Inheritance1
{
    class Purchase
    {
        public string ProductName { get; }
        public int Price { get; }
        public int Count { get; }

        public Purchase(string productname, int price, int count)
        {
            ProductName = productname;
            Price = price;
            Count = count;
        }

        public virtual int GetCost()
        {
            return (Price * Count);
        }

        public override string ToString()
        {
            return (ProductName + ";" + Price + ";" + Count);
        }

        public override bool Equals(object obj)
        {
            var purchase = obj as Purchase;
            return (purchase != null &&
                    ProductName == purchase.ProductName &&
                    Price == purchase.Price);
        }
    }
}