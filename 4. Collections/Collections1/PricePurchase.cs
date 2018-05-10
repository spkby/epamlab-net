namespace Collections1
{
    class PricePurchase : Purchase
    {
        public PricePurchase(string productName, int price, int count, int discount) : base(productName,
            price, count)
        {
            Discount = discount;
        }

        public int Discount { get; private set; }

        public override int GetCost()
        {
            return ((Price - Discount) * Count);
        }

        public override string ToString()
        {
            return (base.ToString() + Constants.Delimiter + Discount);
        }
    }
}