using Inventory.Helpers.Structs;
using NUnit.Framework;

namespace Inventory.Helpers.Tests.Unit.Structs
{
    [TestFixture]
    public class MonetaryTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void GetHashCode_Test01()
        {
            var decimalval = 12.234m;
            Monetary monetary = decimalval;

            Assert.That(decimalval.GetHashCode() == monetary.GetHashCode());
        }

        [Test]
        public void Value_Test01()
        {
            Monetary monetary = 12.234m;

            Assert.That(monetary.Value == 12.234m);
        }

        [Test]
        public void CurrencyValue_Test01()
        {
            Monetary monetary = 12.234m;

            Assert.That(monetary.CurrencyValue == 12.23m);
        }

        [Test]
        public void CurrencyValue_Test02()
        {
            Monetary monetary = 12.235m;

            Assert.That(monetary.CurrencyValue == 12.24m);
        }

        [Test]
        public void ToString_Test01()
        {
            Monetary monetary = 12.235m;

            Assert.That(monetary.ToString() == "12.24");
        }

        [Test]
        public void ToString_Test02()
        {
            Monetary monetary = 12.234m;

            Assert.That(monetary.ToString() == "12.23");
        }

        [Test]
        public void EqualsOperand_Test01()
        {
            Monetary currencya = 12.234m;
            Monetary currencyb = 12.234m;

            Assert.That(currencya == currencyb);
        }

        [Test]
        public void EqualsOperand_Test02()
        {
            Monetary currencya = 12.234m;
            Monetary currencyb = 12.233m;

            Assert.That(currencya != currencyb);
        }

        [Test]
        public void NotEqualsOperand_Test01()
        {
            Monetary currencya = 12.234m;
            Monetary currencyb = 12.234m;

            Assert.That(!(currencya != currencyb));
        }

        [Test]
        public void NotEqualsOperand_Test02()
        {
            Monetary currencya = 12.234m;
            Monetary currencyb = 12.233m;

            Assert.That(currencya != currencyb);
        }

        [Test]
        public void EqualsOperandDecimal_Test01()
        {
            Monetary currencya = 12.234m;
            const decimal currencyb = 12.234m;

            Assert.That(currencya == currencyb);
        }

        [Test]
        public void EqualsOperandDecimal_Test02()
        {
            Monetary currencya = 12.234m;
            const decimal currencyb = 12.233m;

            Assert.That(currencya != currencyb);
        }

        [Test]
        public void NotEqualsOperandDecimal_Test01()
        {
            Monetary currencya = 12.234m;
            const decimal currencyb = 12.233m;

            Assert.That(currencya != currencyb);
        }

        [Test]
        public void NotEqualsOperandDecimal_Test02()
        {
            Monetary currencya = 12.234m;
            const decimal currencyb = 12.234m;

            Assert.That(!(currencya != currencyb));
        }


        [Test]
        public void EqualsMethod_Test01()
        {
            Monetary currencya = 12.234m;
            Monetary currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethod_Test02()
        {
            Monetary currencya = 12.234m;
            Monetary currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodDecimal_Test01()
        {
            Monetary currencya = 12.234m;
            const decimal currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodDecimal_Test02()
        {
            Monetary currencya = 12.234m;
            const decimal currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodObj_Test01()
        {
            Monetary currencya = 12.234m;
            object currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodObj_Test02()
        {
            Monetary currencya = 12.234m;
            object currencyb = 12.234m;

            Assert.That(currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodObj_Test03()
        {
            Monetary currencya = 12.234m;
            object currencyb = 12.234;

            Assert.That(!currencya.Equals(currencyb));
        }

        [Test]
        public void EqualsMethodObj_Test04()
        {
            Monetary currencya = 12.234m;
            object currencyb = "string";

            Assert.That(!currencya.Equals(currencyb));
        }

        [Test]
        public void AddOperand_Test01_decimal()
        {
            Monetary monetary = 12.234m;
            decimal dec = 18.234m;

            Monetary expected = 30.468m;

            Assert.That(expected == (monetary + dec));
        }

        [Test]
        public void AddOperand_Test02_currency()
        {
            Monetary currencya = 12.234m;
            Monetary currencyb = 18.234m;

            Monetary expected = 30.468m;

            Assert.That(expected == (currencya + currencyb));
        }

        [Test]
        public void MultiplyOperand_Test01_Int()
        {
            Monetary monetary = 10;
            int multiple = 12;

            Assert.That((monetary * multiple) == 120m);
        }

        [Test]
        public void MultiplyOperand_Test02_decimal()
        {
            Monetary monetary = 10.5m;
            decimal multiple = 12.2m;

            Assert.That((monetary * multiple) == 128.1m);
        }
    }
}
