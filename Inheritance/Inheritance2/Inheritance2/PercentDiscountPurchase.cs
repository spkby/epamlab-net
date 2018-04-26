namespace Inheritance2
{
    class PercentDiscountPurchase : AbstractPurchase
    {
        public PercentDiscountPurchase(Commodity commodity, int count, int discountPercent) : base(commodity, count)
        {
            DiscountPercent = discountPercent;
        }

        public const int DiscountCount = 0;
        public int DiscountPercent { get; }

        public override int GetCost()
        {
            int cost = CalcCost();
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