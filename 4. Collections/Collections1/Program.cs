using System;

namespace Collections1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int main = 0;
            const int additional = 1;

            if (args.Length < 2)
            {
                Console.WriteLine("command line: Collections1.exe main addon");
                return;
            }

            var mainFile = args[main];
            var addonFile = args[additional];

            var mainCollection = new PurchaseCollection(mainFile);

            Print(mainCollection, "after creation");
            
            var addonCollection = new PurchaseCollection(addonFile);

            mainCollection.Insert(0, addonCollection.GetPurchaseByIndex(addonCollection.Size() - 1));
            mainCollection.Insert(1000, addonCollection.GetPurchaseByIndex(0));
            mainCollection.Insert(2, addonCollection.GetPurchaseByIndex(2));

            if (mainCollection.Delete(3) < 0) {
                PrintErr("Error Deletion: invalid index");
            }
            if (mainCollection.Delete(10) < 0) {
                PrintErr("Error Deletion: invalid index");
            }
            if (mainCollection.Delete(-5) < 0) {
                PrintErr("Error Deletion: invalid index");
            }

            Print(mainCollection, "before sorting");

            mainCollection.Sort(new Comparator());

            Print(mainCollection, "after sorting");

            Search(mainCollection, addonCollection, 1);
            Search(mainCollection, addonCollection, 3);
        }

        private static void Print(PurchaseCollection collection, string header)
        {
            Console.WriteLine(header);
            collection.Print();
        }

        private static void Search(PurchaseCollection main, PurchaseCollection addon, int index)
        {
            var purchase = addon.GetPurchaseByIndex(index);
            var id = main.Search(purchase, new Comparator());
            Console.WriteLine("Purchase " + purchase + (id >= 0 ? " is found at position " + id : " isn't found"));
        }

        private static void PrintErr(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}