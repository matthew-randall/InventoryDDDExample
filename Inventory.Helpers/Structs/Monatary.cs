using System;

namespace Inventory.Helpers.Structs
{
    public struct Monetary
    {
        private readonly decimal _value;

        private Monetary(decimal value)
        {
            _value = value;
        }

        public decimal Value
        {
            get { return _value; }
        }

        public decimal CurrencyValue
        {
            get { return decimal.Round(_value, 2, MidpointRounding.ToEven); }
        }

        public override string ToString()
        {
            return string.Format("{0:0.00}", CurrencyValue);
        }

        public static implicit operator Monetary(decimal value)
        {
            var currency = new Monetary(value);
            return currency;
        }

        public static bool operator ==(Monetary monetary, decimal value)
        {
            return monetary.Value == value;
        }

        public static bool operator !=(Monetary monetary, decimal value)
        {
            return monetary.Value != value;
        }

        public static bool operator ==(Monetary currencya, Monetary currencyb)
        {
            return currencya.Value == currencyb.Value;
        }

        public static bool operator !=(Monetary currencya, Monetary currencyb)
        {
            return currencya.Value != currencyb.Value;
        }

        public static Monetary operator +(Monetary monetary, decimal value)
        {
            return monetary.Value + value;
        }

        public static Monetary operator +(Monetary monetary, Monetary value)
        {
            return monetary.Value + value.Value;
        }
        
        public static Monetary operator *(Monetary monetary, int value)
        {
            return monetary.Value*value;
        }

        public static Monetary operator *(Monetary monetary, decimal value)
        {
            return monetary.Value * value;
        }
        
        public bool Equals(Monetary other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) 
                return false;

            if (obj is Monetary)
                return this == (Monetary)obj;

            if (obj is decimal)
                return this == (decimal)obj;

            return false;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
