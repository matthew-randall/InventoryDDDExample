using System;

namespace Inventory.Application.Base.Contacts.Structs
{
    public struct Currency
    {
        private readonly decimal _value;

        private Currency(decimal value)
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

        public static implicit operator Currency(decimal value)
        {
            var currency = new Currency(value);
            return currency;
        }

        public static bool operator ==(Currency currency, decimal value)
        {
            return currency.Value == value;
        }

        public static bool operator !=(Currency currency, decimal value)
        {
            return currency.Value != value;
        }

        public static bool operator ==(Currency currencya, Currency currencyb)
        {
            return currencya.Value == currencyb.Value;
        }

        public static bool operator !=(Currency currencya, Currency currencyb)
        {
            return currencya.Value != currencyb.Value;
        }
        public bool Equals(Currency other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) 
                return false;

            if (obj is Currency)
                return this == (Currency)obj;

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
