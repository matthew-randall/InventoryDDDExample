using Inventory.Application.Sales.Credits.QueryDomain;
using Inventory.Application.Sales.Credits.QueryDomain.Interfaces;
using Inventory.Repository.Base.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.Credits.QueryDomain
{
    [TestFixture]
    public class CreditLineViewTests
    {
        private CreditLineView _creditLineView;
        private CreditViewLineDt _creditViewLineDt;

        [SetUp]
        public void SetUp()
        {
            _creditViewLineDt = new CreditViewLineDt();
            _creditLineView = new CreditLineView(_creditViewLineDt);
        }

        [Test]
        public void Initialise_Test01()
        {
            var mockedCreditView = new Mock<ICreditView>();

            var creditLineView = new CreditLineView(null);
            creditLineView.Initialise(mockedCreditView.Object);

            Assert.That(creditLineView.CreditView, Is.EqualTo(mockedCreditView.Object));
        }

        [Test]
        public void Price_Test01()
        {
            _creditViewLineDt.CreditPrice = 123.43m;

            Assert.That(_creditLineView.Price == _creditViewLineDt.CreditPrice);
        }
        
        [Test]
        public void Quantity_Test01()
        {
            _creditViewLineDt.CreditQuantity = 2;

            Assert.That(_creditLineView.Quantity == 2);
        }

        [Test]
        public void TaxRate_Test01()
        {
            _creditViewLineDt.TaxRate = 2.995m;

            Assert.That(_creditLineView.TaxRate == 2.995m);
        }

        [Test]
        public void SubTotal_Test01()
        {
            _creditViewLineDt.CreditQuantity = 2;
            _creditViewLineDt.CreditPrice = 10.10m;

            Assert.That(_creditLineView.SubTotal == 20.2m);
        }

        [Test]
        public void TaxTotal_Test01()
        {
            _creditViewLineDt.CreditQuantity = 2;
            _creditViewLineDt.CreditPrice = 10.10m;
            _creditViewLineDt.TaxRate = 0.125m;

            Assert.That(_creditLineView.TaxTotal == (20.2m * 0.125m));
        }

        [Test]
        public void TaxTotal_Test01_ZeroTaxRate()
        {
            _creditViewLineDt.CreditQuantity = 2;
            _creditViewLineDt.CreditPrice = 10.10m;
            _creditViewLineDt.TaxRate = 0m;

            Assert.That(_creditLineView.TaxTotal == 0m);
        }

        [Test]
        public void Total_Test01_ZeroTax()
        {
            _creditViewLineDt.CreditQuantity = 2;
            _creditViewLineDt.CreditPrice = 10.10m;
            _creditViewLineDt.TaxRate = 0m;

            Assert.That(_creditLineView.Total == 20.2m);
        }

        [Test]
        public void Total_Test02_Tax()
        {
            _creditViewLineDt.CreditQuantity = 2;
            _creditViewLineDt.CreditPrice = 10.10m;
            _creditViewLineDt.TaxRate = 0.125m;

            Assert.That(_creditLineView.Total == 20.2m + (20.2m * 0.125m));
        }
        
        /*
        [Test]
        public void Total_Test01()
        {
            var creditLineViewDt = new CreditViewLineDt();

            creditLineViewDt.CreditPrice = 13.435m;
            creditLineViewDt.CreditQuantity = 6;
            creditLineViewDt.TaxRate = 0.12125m;

            var creditLineView = new CreditLineView(creditLineViewDt);

            Assert.That(creditLineView.Total == 13.435);
        }
        */
    }
}
