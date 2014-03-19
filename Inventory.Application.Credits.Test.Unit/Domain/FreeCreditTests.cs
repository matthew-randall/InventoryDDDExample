using System;
using System.Collections.Generic;
using Inventory.Application.Credits.Domain;
using Inventory.Repository.Base.Contracts.Models;
using NUnit.Framework;

namespace Inventory.Application.Credits.Tests.Unit.Domain
{
    [TestFixture]
    public class FreeCreditTests : BaseCreditTests
    {
        private Credit _credit;

        [SetUp]
        public void SetUp()
        {
            CreditDt = new CreditDt();
            BaseCredit = _credit = new Credit(CreditDt);
        }

        [Test]
        public void Customer_Test01()
        {

        }

        [Test]
        public void GetCreditViewModel_Test01()
        {

        }

        [Test]
        public void GetCreditNoteLine_Test01()
        {

        }

        [Test]
        public void CreateCreditLines_Test01()
        {

        }
    }
}
