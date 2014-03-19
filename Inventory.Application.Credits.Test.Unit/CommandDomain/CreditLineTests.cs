using System;
using Inventory.Application.Credits.CommandDomain;
using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Credits.Tests.Unit.CommandDomain
{
    [TestFixture]
    public class CreditLineTests : BaseCreditLineTests
    {
        private Mock<ICredit> _mockedCredit;
        private CreditLine _creditLine;

        [SetUp]
        public void SetUp()
        {
            CreditLineDt = new CreditLineDt();
            _mockedCredit = new Mock<ICredit>();

            BaseCreditLine = _creditLine = new CreditLine(_mockedCredit.Object, CreditLineDt);
        }

        [Test]
        public void GetCreditLineViewModel_Test01()
        {

        }

        [Test]
        public void Update_Test01()
        {

        }

        [Test]
        public void SalesInvoiceLine_Test01()
        {

        }
    }
}
