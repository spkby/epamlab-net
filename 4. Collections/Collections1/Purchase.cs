using System;

namespace Collections1
{
    public class Purchase
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Count { get; private set; }

        public Purchase(string name, int price, int count)
        {
            SetName(name);
            SetPrice(price);
            SetCount(count);
        }

        private void SetName(string name)
        {
            if (name == null)
            {
                throw new InvalidArgumentException(Constants.ErrorNullName);
            }

            if (name.Length == 0)
            {
                throw new InvalidArgumentException(Constants.ErrorEmptyName);
            }

            Name = name;
        }

        private void SetCount(int count)
        {
            CheckPositive(count, Fields.FieldsPosition.Count);
            Count = count;
        }

        private void SetPrice(int price)
        {
            CheckPositive(price, Fields.FieldsPosition.Price);
            Price = price;
        }

        protected static void CheckPositive(int value, Fields.FieldsPosition field)
        {
            if (value <= 0)
            {
                throw new NonpositiveArgumentException(value, field);
            }
        }

        public virtual int GetCost()
        {
            return (Price * Count);
        }

        public override string ToString()
        {
            return (Name + Constants.Delimiter + Price + Constants.Delimiter + Count);
        }

        public override bool Equals(object obj)
        {
            var purchase = obj as Purchase;
            return (purchase != null &&
                    Name == purchase.Name &&
                    Price == purchase.Price);
        }
    }
}