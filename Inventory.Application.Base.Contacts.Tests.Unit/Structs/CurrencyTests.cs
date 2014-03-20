using Inventory.Application.Base.Contacts.Structs;
using NUnit.Framework;

namespace Inventory.Application.Base.Contacts.Tests.Unit.Structs
{
    [TestFixture]
    public class CurrencyTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void GetHashCode_Test01()
        {
            var decimalval = 12.234m;
            Currency currency = decimalval;

            Assert.That(decimalval.GetHashCode() == currency.GetHashCode());
        }

        [Test]
        public void Value_Test01()
        {
            Currency currency = 12.234m;

            Assert.That(currency.Value == 12.234m);
        }

        [Test]
        public void CurrencyValue_Test01()
        {
            Currency currency = 12.234m;

            Assert.That(currency.CurrencyValue == 12.23m);
        }

        [Test]
        public void CurrencyValue_Test02()
        {
            Currency currency = 12.235m;

            Assert.That(currency.CurrencyValue == 12.24m);
        }

        [Test]
        public void ToString_Test01()
        {
            Currency currency = 12.235m;

            Assert.That(currency.ToString() == "12.24");
        }

        [Test]
        public void ToString_Test02()
        {
            Currency currency = 12.234m;

            Assert.That(currency.ToString() == "12.23");
        }

        [Test]
        public void EqualsOperand_Test01()
        {
            Currency currencya = 12.234m;
            Currency currencyb = 12.234m;

            Assert.That(currencya == currencyb);
        }

        [Test]
        public void EqualsOperand_Test02()
        {
            Currency currencya = 12.234m;
            Currency currencyb = 12.233m;

            Assert.That(currencya != currencyb);
        }

        [Test]
        public void NotEqualsOperand_Test01()
        {
            Currency currencya = 12.234m;
            Currency currencyb = 12.234m;

            Assert.That(!(currencya != currencyb));
        }

        [Test]
        public void NotEqualsOperand_Test02()
        {
            Currency currencya = 12.234m;
            Currency currencyb = 12.233m;

            Assert.That(currencya != currencyb);
        }

        [Test]
        public void EqualsOperandDecimal_Test01()
        {
            Currency currencya = 12.234m;
            const decimal currencyb = 12.234m;

            Assert.That(currencya == currencyb);
        }

        [Test]
        public void EqualsOperandDecimal_Test02()
        {
            Currency currencya = 12.234m;
            const decimal currencyb = 12.233m;

            Assert.That(currencya != currencyb);
        }

        [Test]
        public void NotEqualsOperandDecimal_Test01()
        {
            Currency currencya = 12.234m;
            const decimal currencyb = 12.233m;

            Assert.That(currencya != currencyb);
        }

        [Test]
        public void NotEqualsOperandDecimal_Test02()
        {
            Currency currencya = 12.234m;
            const decimal currencyb = 12.234m;

            Assert.That(!(currencya != currencyb));
        }


        [Test]
        public void EqualsMethod_Test01()
        {
            Currency currencya = 12.234m;
            Currency currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethod_Test02()
        {
            Currency currencya = 12.234m;
            Currency currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodDecimal_Test01()
        {
            Currency currencya = 12.234m;
            const decimal currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodDecimal_Test02()
        {
            Currency currencya = 12.234m;
            const decimal currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodObj_Test01()
        {
            Currency currencya = 12.234m;
            object currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodObj_Test02()
        {
            Currency currencya = 12.234m;
            object currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodObj_Test03()
        {
            Currency currencya = 12.234m;
            object currencyb = 12.234;

            Assert.That(!currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodObj_Test04()
        {
            Currency currencya = 12.234m;
            object currencyb = "string";

            Assert.That(!currencya.Equals(currencyb));
        }
    }
}
