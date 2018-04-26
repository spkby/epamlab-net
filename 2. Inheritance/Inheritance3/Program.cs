using System;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractOperation[] operations =
            {
                new AddOperation(0, 0),
                new AddOperation(0, 0),
                new SubOperation(0, 0),
                new SubOperation(0, 0),
                new MulOperation(0, 0),
                new MulOperation(0, 0),
                new DivOperation(0, 0),
                new DivOperation(0, 0),
                new PowOperation(0, 0),
                new PowOperation(0, 0)
            };

            PrintPurchases(operations);

            Array.Sort(operations);

            PrintPurchases(operations);

            Console.Read();
        }

        private static void PrintPurchases(AbstractOperation[] operations)
        {
            foreach (var operation in operations)
            {
                Console.WriteLine(operation);
            }
        }
    }
}