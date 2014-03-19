using Inventory.Application.Credits.Domain;
using Inventory.Repository.Base.Contracts.Models;
using NUnit.Framework;

namespace Inventory.Application.Credits.Tests.Unit.Domain
{
    public abstract class BaseCreditLineTests
    {
        protected CreditLineDt CreditLineDt;
        internal BaseCreditLine BaseCreditLine;

        [Test]
        public void CreditLineId_Test01()
        {
            Assert.That(BaseCreditLine.CreditLineId == CreditLineDt.CreditLineId);
        }

        [Test]
        public void CreditPrice_Test01()
        {
            Assert.That(BaseCreditLine.CreditPrice == CreditLineDt.CreditPrice);
        }

        [Test]
        public void CreditQuantity_Test01()
        {
            Assert.That(BaseCreditLine.CreditQuantity == CreditLineDt.CreditQuantity);
        }

        [Test]
        public void SubTotal_Test01()
        {
            Assert.That(BaseCreditLine.SubTotal == (CreditLineDt.CreditPrice * CreditLineDt.CreditQuantity));
        }

        [Test]
        public void TaxRate_Test01()
        {
            Assert.That(BaseCreditLine.TaxRate == CreditLineDt.TaxRate);
        }

        [Test]
        public void LineTax_Test01()
        {

        }

        [Test]
        public void Total_Test01()
        {

        }

        [Test]
        public void LineNumber_Test01()
        {
            Assert.That(BaseCreditLine.LineNumber == CreditLineDt.LineNumber);
        }

        [Test]
        public void ReturnToStock_Test01()
        {
            Assert.That(BaseCreditLine.ReturnToStock == CreditLineDt.ReturnToStock);
        }

        [Test]
        public void Notes_Test01()
        {
            Assert.That(BaseCreditLine.Notes == CreditLineDt.Notes);
        }

        [Test]
        public void CreditReasonId_Test01()
        {
            Assert.That(BaseCreditLine.CreditReasonId == CreditLineDt.CreditReasonDtId);
        }
    }
}
