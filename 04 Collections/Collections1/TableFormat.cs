using System;

namespace Collections1
{
    public class Fields
    {
        public enum FieldsPosition
        {
            Name,
            Price,
            Count,
            Discount,
            Cost
        }

        public static readonly string[] FieldsName =
        {
            "Name", "Price", "Count", "Discount", "Cost"
        };

        public static readonly int[] FieldsFormat =
        {
            -10, 6, 6, 9, 7
        };

        public static readonly int TotalCostFormat = CalcTotalCostFormat();

        private static int CalcTotalCostFormat()
        {
            var total = 0;
            foreach (var f in FieldsFormat)
            {
                total += Math.Abs(f);
            }

            total -= FieldsFormat[(int) FieldsPosition.Discount];
            total -= Constants.TotalCost.Length;
            return total;
        }
    }
}