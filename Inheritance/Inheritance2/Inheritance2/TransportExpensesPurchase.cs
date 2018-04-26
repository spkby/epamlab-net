namespace Inheritance2
{
    class TransportExpensesPurchase : AbstractPurchase
    {
        public TransportExpensesPurchase(Commodity commodity, int count, int transportExpenses) : base(commodity, count)
        {
            TransportExpenses = transportExpenses;
        }

        public int TransportExpenses { get; }

        public override int GetCost()
        {
            return (CalcCost() + TransportExpenses);
        }

        public override string ToString()
        {
            return (base.ToString() + ";" + TransportExpenses);
        }
    }
}