namespace Collections1
{
    class Purchase
    {
        public string ProductName { get; private set; }
        public int Price { get; private set; }
        public int Count { get; private set; }

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
            return (ProductName + Constants.Delimiter + Price + Constants.Delimiter + Count);
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