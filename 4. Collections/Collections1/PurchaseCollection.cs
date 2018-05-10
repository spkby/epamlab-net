using System;
using System.Collections.Generic;
using System.IO;

namespace Collections1
{
    public class PurchaseCollection
    {
        private List<Purchase> Purchases;

        public PurchaseCollection()
        {
            Purchases = new List<Purchase>();
        }

        public PurchaseCollection(string csvFile) : this()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Constants.Path + csvFile + Constants.Ext))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        try
                        {
                            Purchases.Add(createPurchase(line));
                        }
                        catch (CsvLineException e)
                        {
                            Console.WriteLine(Constants.Error + e.Message);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(Constants.FileNotFound);
            }
        }

        private Purchase createPurchase(string csvString)
        {
            string[] elements = csvString.Split(Constants.Delimiter);

            if (elements.Length != 3 || elements.Length != 4)
            {
            }

            return null;
        }

        void Insert(int index, Purchase p)
        {
        }

        int Delete(int index)
        {

            return Purchases.Count;
        }

        decimal TotalCost()
        {
            return 0;
        }

        void Print()
        {
        }

        public void Sort(/*IComparer<Purchase> cmp*/)
        {
        }
    }
}