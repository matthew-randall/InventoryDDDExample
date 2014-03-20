using System;
using Inventory.Application.Credits.QueryDomain.Interfaces;
using Inventory.Application.Credits.Services.ModelBuilders;
using Inventory.Repository.Base.Contracts.Enum;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Credits.Tests.Unit.Services.ModelBuilders
{
    [TestFixture]
    public class CreditViewQueryModelBuilderTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void Build_Test01()
        {
            const string creditNumber = "creditNumber";
            const string customerCode = "code";
            const string invoiceNumber = "c";
            var creditDate = DateTime.UtcNow;
            const string customerName = "d";
            const CreditStatus status = CreditStatus.Parked;
            Base.Contacts.Structs.Currency total = 12.23432m;

            var mockedCreditView = new Mock<ICreditView>();

            mockedCreditView.Setup(x => x.CreditNumber).Returns(creditNumber);
            mockedCreditView.Setup(x => x.CustomerCode).Returns(customerCode);
            mockedCreditView.Setup(x => x.InvoiceNumber).Returns(invoiceNumber);
            mockedCreditView.Setup(x => x.CreditDate).Returns(creditDate);
            mockedCreditView.Setup(x => x.CustomerName).Returns(customerName);
            mockedCreditView.Setup(x => x.CreditStatus).Returns(status);
            mockedCreditView.Setup(x => x.Total).Returns(total);

            var builder = new CreditViewQueryModelBuilder();

            var response = builder.Build(mockedCreditView.Object);

            Assert.That(response.CreditNumber == creditNumber);
            Assert.That(response.CustomerCode == customerCode);
            Assert.That(response.InvoiceNumber == invoiceNumber);
            Assert.That(response.CreditDate == creditDate.ToShortDateString());
            Assert.That(response.CustomerName == customerName);
            Assert.That(response.Status == status.ToString());
            Assert.That(response.Total == total);
        }
    }
}
