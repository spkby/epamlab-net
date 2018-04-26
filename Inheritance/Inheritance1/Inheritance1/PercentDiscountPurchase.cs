namespace Inheritance1
{
    class PercentDiscountPurchase : Purchase
    {
        public PercentDiscountPurchase(string productName, int price, int count, int discountPercent) : base(
            productName, price, count)
        {
            DiscountPercent = discountPercent;
        }

        public const int DiscountCount = 0;
        public int DiscountPercent { get; }

        public override int GetCost()
        {
            int cost = base.GetCost();
            if (Count > DiscountCount)
            {
                cost = (int) (cost * (1.0 - DiscountPercent / 100.0));
            }

            return cost;
        }

        public override string ToString()
        {
            return (base.ToString() + ";" + DiscountPercent + ";" + DiscountCount);
        }
    }
}