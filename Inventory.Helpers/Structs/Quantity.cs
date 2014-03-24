namespace Inventory.Helpers.Structs
{
    public struct Quantity
    {
        public bool Equals(Quantity other)
        {
            return string.Equals(_quantity, other._quantity);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Quantity && Equals((Quantity) obj);
        }

        public override int GetHashCode()
        {
            return _quantity.GetHashCode();
        }

        private readonly int _quantity;

        private Quantity(int quantity)
        {
            _quantity = quantity;
        }

        public static implicit operator Quantity(int value)
        {
            var quantity = new Quantity(value);
            return quantity;
        }

        public static bool operator ==(Quantity quantity, int value)
        {
            return quantity._quantity == value;
        }

        public static bool operator !=(Quantity quantity, int value)
        {
            return quantity._quantity != value;
        }

        public override string ToString()
        {
            return _quantity.ToString();
        }
    }
}
