using System;

namespace Collections1
{
    class PricePurchase : Purchase
    {
        public PricePurchase(string productName, int price, int count, int discount) : base(productName,
            price, count)
        {
            SetDiscount(discount);
        }

        public int Discount { get; private set; }

        private void SetDiscount(int discount)
        {
            CheckPositive(discount, Fields.FieldsPosition.Discount);
            Discount = discount;
            if (Price - Discount <= 0)
            {
                throw new InvalidArgumentException(Constants.ErrorPriceAfterDiscount);
            }
        }

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