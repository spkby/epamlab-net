namespace Collections1
{
    public class PrintPurchase
    {
        public static string GetRow(Purchase purchase, string format)
        {
            return string.Format(format, purchase.Name, purchase.Price, purchase.Count,
                purchase.GetCost(), GetDisount(purchase));
        }

        private static string GetDisount(Purchase purchase)
        {
            return (purchase is PricePurchase
                ? ((PricePurchase) purchase).Discount.ToString()
                : Constants.EmptyDiscount.ToString());
        }
    }
}