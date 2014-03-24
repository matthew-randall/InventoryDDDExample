using System;
using Inventory.Application.Sales.Credits.CommandDomain;
using Inventory.Helpers.Enum;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.Credits.CommandDomain
{
    public abstract class BaseCreditTests
    {
        protected CreditDt CreditDt;
        internal BaseCredit BaseCredit;

        [Test]
        public void CreditId_Test01()
        {
            CreditDt.CreditId = Guid.NewGuid();

            Assert.That(BaseCredit.CreditId == CreditDt.CreditId);
        }

        [Test]
        public void CreditNumber_Test01()
        {
            CreditDt.CreditNumber = "CREDITNUMBER";
            Assert.That(BaseCredit.CreditNumber == CreditDt.CreditNumber);
        }

        [Test]
        public void SubTotal_Test01()
        {

        }

        [Test]
        public void TaxTotal_Test01()
        {

        }

        [Test]
        public void Total_Test01()
        {

        }

        [Test]
        public void CreditDate_Test01()
        {
            CreditDt.CreditDate = DateTime.UtcNow;
            Assert.That(BaseCredit.CreditDate == CreditDt.CreditDate);

        }

        [Test]
        public void Notes_Test01()
        {
            CreditDt.Notes = "Notes";
            Assert.That(BaseCredit.Notes == CreditDt.Notes);
        }

        [Test]
        public void CreditStatus_Test01()
        {
            CreditDt.Status = CreditStatus.Parking;
            Assert.That(BaseCredit.CreditStatus == CreditDt.Status);
        }

        [Test]
        public void CreditType_Test01()
        {
            CreditDt.CreditType = CreditType.FreeCredit;
            Assert.That(BaseCredit.CreditType == CreditDt.CreditType);
        }

        [Test]
        public void CreditLines_Test01()
        {

        }

        [Test]
        public void CreditLinesView_Test01()
        {

        }
    }
}
