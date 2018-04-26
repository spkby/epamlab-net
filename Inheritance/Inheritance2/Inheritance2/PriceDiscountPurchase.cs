namespace Inheritance2
{
    class PriceDiscountPurchase : AbstractPurchase
    {
        public PriceDiscountPurchase(Commodity commodity, int count, int discountPrice) : base(commodity, count)
        {
            DiscountPrice = discountPrice;
        }

        public int DiscountPrice { get; }

        public override int GetCost()
        {
            return ((Commodity.Price - DiscountPrice) * Count);
        }

        public override string ToString()
        {
            return (base.ToString() + ";" + DiscountPrice);
        }
    }
}