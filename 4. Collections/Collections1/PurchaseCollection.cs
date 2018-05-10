using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Collections1
{
    public class PurchaseCollection
    {
        private readonly List<Purchase> _purchases;

        private bool _ordered = false;

        private const int PurchaseFieldsNumber = 3;
        private const int PricePurchaseFieldsNumber = 4;

        public PurchaseCollection()
        {
            _purchases = new List<Purchase>();
        }

        public PurchaseCollection(string csvFile) : this()
        {
            try
            {
                using (var sr = new StreamReader(Constants.Path + csvFile + Constants.Ext))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Purchase purchase = null;
                        try
                        {
                            purchase = CreatePurchase(line);
                        }
                        catch (CsvLineException e)
                        {
                            Console.WriteLine(e);
                        }

                        if (purchase != null)
                        {
                            _purchases.Add(purchase);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(Constants.FileNotFoundHead + csvFile + Constants.FileNotFoundTail);
            }
        }

        public int Size()
        {
            return _purchases.Count;
        }

        private static Purchase CreatePurchase(string csvString)
        {
            Purchase purchase;

            var elements = csvString.Split(Constants.Delimiter);

            if ((elements.Length != PurchaseFieldsNumber) &&
                (elements.Length != PricePurchaseFieldsNumber))
            {
                throw new CsvLineException(csvString, Constants.ErrorWrongNumber);
            }

            int price, count;

            var name = elements[(int) Fields.FieldsPosition.Name];

            if (!int.TryParse(elements[(int) Fields.FieldsPosition.Price], out price))
            {
                throw new CsvLineException(csvString, Constants.ErrorFailedConversion);
            }

            if (!int.TryParse(elements[(int) Fields.FieldsPosition.Count], out count))
            {
                throw new CsvLineException(csvString, Constants.ErrorFailedConversion);
            }

            try
            {
                if (elements.Length == PurchaseFieldsNumber)
                {
                    purchase = new Purchase(name, price, count);
                }
                else
                {
                    int discount;
                    if (!int.TryParse(elements[(int) Fields.FieldsPosition.Discount], out discount))
                    {
                        throw new CsvLineException(csvString, Constants.ErrorFailedConversion);
                    }

                    purchase = new PricePurchase(name, price, count, discount);
                }
            }
            catch (CsvLineException e)
            {
                throw new CsvLineException(e);
            }
            catch (ArgumentException e)
            {
                throw new CsvLineException(csvString, e);
            }

            return purchase;
        }

        public void Insert(int index, Purchase p)
        {
            if (index < 0)
            {
                index = 0;
            }

            if (index > _purchases.Count)
            {
                index = _purchases.Count;
            }

            _purchases.Insert(index, p);
        }

        private void UnOrdered()
        {
            _ordered = false;
        }

        private bool IsCorrectIndex(int index)
        {
            return (index >= 0 && index < _purchases.Count);
        }

        public int Delete(int index)
        {
            int result;
            if (IsCorrectIndex(index))
            {
                _purchases.RemoveAt(index);
                result = _purchases.Count;
                UnOrdered();
            }
            else
            {
                result = -1;
            }

            return result;
        }

        public int GetTotalCost()
        {
            var totalCost = 0;

            foreach (var purchase in _purchases)
            {
                totalCost += purchase.GetCost();
            }

            return totalCost;
        }

        public void Print()
        {
            var builder = new StringBuilder();

            var format =
                "{0," + Fields.FieldsFormat[(int) Fields.FieldsPosition.Name] + "}" +
                "{1," + Fields.FieldsFormat[(int) Fields.FieldsPosition.Price] + "}" +
                "{2," + Fields.FieldsFormat[(int) Fields.FieldsPosition.Count] + "}" +
                "{3," + Fields.FieldsFormat[(int) Fields.FieldsPosition.Cost] + "}" +
                "{4," + Fields.FieldsFormat[(int) Fields.FieldsPosition.Discount] + "}";

            builder.AppendLine(string.Format(format, Fields.FieldsName[(int) Fields.FieldsPosition.Name],
                Fields.FieldsName[(int) Fields.FieldsPosition.Price],
                Fields.FieldsName[(int) Fields.FieldsPosition.Count],
                Fields.FieldsName[(int) Fields.FieldsPosition.Cost],
                Fields.FieldsName[(int) Fields.FieldsPosition.Discount]));

            foreach (var purchase in _purchases)
            {
                builder.AppendLine(PrintPurchase.GetRow(purchase, format));
            }

            format = "{0," + Fields.TotalCostFormat + "}";
            builder.AppendLine(string.Format(Constants.TotalCost + format, GetTotalCost()));

            Console.WriteLine(builder);
        }

        public void Sort(IComparer<Purchase> cmp)
        {
            _purchases.Sort(cmp);
            _ordered = true;
        }

        public int Search(Purchase purchase, IComparer<Purchase> cmp)
        {
            if (!_ordered)
            {
                Sort(cmp);
            }

            return _purchases.BinarySearch(purchase, cmp);
        }

        public Purchase GetPurchaseByIndex(int index)
        {
            Purchase purchase = null;
            if (IsCorrectIndex(index))
            {
                purchase = _purchases[index];
            }

            return purchase;
        }
    }
}