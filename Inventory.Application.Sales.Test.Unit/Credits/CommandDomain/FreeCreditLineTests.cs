﻿using Inventory.Application.Sales.Credits.CommandDomain;
using Inventory.Application.Sales.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.Credits.CommandDomain
{
    [TestFixture]
    public class FreeCreditLineTests : BaseCreditLineTests
    {
        private Mock<ICredit> _mockedCredit;
        private FreeCreditLine _creditLine;

        [SetUp]
        public void SetUp()
        {
            CreditLineDt = new CreditLineDt();
            _mockedCredit = new Mock<ICredit>();

            BaseCreditLine = _creditLine = new FreeCreditLine(_mockedCredit.Object, CreditLineDt);
        }

        [Test]
        public void GetCreditLineViewModel_Test01()
        {

        }

        [Test]
        public void Update_Test01()
        {

        }
    }
}
