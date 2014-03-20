using System;
using System.Linq;
using Inventory.Application.Credits.Contracts.Queries;
using Inventory.Application.Credits.QueryDomain;
using Inventory.Application.Credits.QueryDomain.Interfaces;
using Inventory.Application.Credits.Services.ModelBuilders.Interfaces;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Credits.Tests.Unit.QueryDomain
{
    [TestFixture]
    public class CreditViewTests
    {
        private CreditViewDt _creditViewDt;
        private CreditView _creditView;
        private Mock<CreditView> _mockedCreditView;
        private Mock<ICreditViewQueryModelBuilder> _mockedCreditViewQueryModelBuilder;

        [SetUp]
        public void SetUp()
        {
            _creditViewDt = new CreditViewDt
            {
                CreditId = Guid.NewGuid(),
                CustomerCode = "CustomerCode",
                CustomerName = "CustomerName",
                CreditDate = DateTime.UtcNow,
                CreditNumber = "CR-001",
                InvoiceNumber = "INV-001",
                Status = CreditStatus.Parked
            };

            _mockedCreditViewQueryModelBuilder = new Mock<ICreditViewQueryModelBuilder>();

            _mockedCreditView = new Mock<CreditView>(_creditViewDt);

            _mockedCreditView.Setup(x => x.InstantiateCreditViewQueryModelBuilder())
                .Returns(_mockedCreditViewQueryModelBuilder.Object);

            _creditView = _mockedCreditView.Object;
        }

        [Test]
        public void Initialise_Test01()
        {
            var mockedCreditLineView1 = new Mock<ICreditLineView>();
            var mockedCreditLineView2 = new Mock<ICreditLineView>();

            var creditView = new CreditView(null);

            creditView.InitialiseLine(mockedCreditLineView1.Object);
            creditView.InitialiseLine(mockedCreditLineView2.Object);

            Assert.That(creditView.CreditLineViews.First(), Is.EqualTo(mockedCreditLineView1.Object));
            Assert.That(creditView.CreditLineViews.Last(), Is.EqualTo(mockedCreditLineView2.Object));
        }

        [Test]
        public void CreditId_Test01()
        {
            Assert.That(_creditView.CreditNumber == _creditViewDt.CreditNumber); 
        }

        [Test]
        public void CreditNumber_Test01()
        {
            Assert.That(_creditView.CreditId == _creditViewDt.CreditId);
        }

        [Test]
        public void CustomerCode_Test01()
        {
            Assert.That(_creditView.CustomerCode == _creditViewDt.CustomerCode);
        }

        [Test]
        public void CustomerName_Test01()
        {
            Assert.That(_creditView.CustomerName == _creditViewDt.CustomerName);
        }

        [Test]
        public void CreditDate_Test01()
        {
            Assert.That(_creditView.CreditDate == _creditViewDt.CreditDate);
        }

        [Test]
        public void InvoiceNumber_Test01()
        {
            Assert.That(_creditView.InvoiceNumber == _creditViewDt.InvoiceNumber);
        }

        [Test]
        public void Status_Test01()
        {
            Assert.That(_creditView.CreditStatus == _creditViewDt.Status);
        }

        [Test]
        public void GetCreditViewQuery_Test01_InstantiateBuilder()
        {
            _creditView.GetCreditViewQuery();
            _mockedCreditView.Verify(x => x.InstantiateCreditViewQueryModelBuilder(), Times.Once);
        }
        
        [Test]
        public void GetCreditViewQuery_Test02_BuildModel()
        {
            _creditView.GetCreditViewQuery();
            _mockedCreditViewQueryModelBuilder.Verify(x => x.Build(_creditView), Times.Once);
        }

        [Test]
        public void GetCreditViewQuery_Test03_ReturnModel()
        {
            var queryModel = new CreditViewQuery();

            _mockedCreditViewQueryModelBuilder.Setup(x => x.Build(_creditView)).Returns(queryModel);
            var result = _creditView.GetCreditViewQuery();

            Assert.That(queryModel == result);
        }
    }
}
