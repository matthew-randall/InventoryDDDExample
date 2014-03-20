using Inventory.Application.Credits.QueryDomain;
using Inventory.Application.Credits.QueryDomain.Interfaces;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Credits.Tests.Unit.QueryDomain
{
    [TestFixture]
    public class CreditLineViewTests
    {
        [Test]
        public void Initialise_Test01()
        {
            var mockedCreditView = new Mock<ICreditView>();

            var creditLineView = new CreditLineView(null);
            creditLineView.Initialise(mockedCreditView.Object);

            Assert.That(creditLineView.CreditView, Is.EqualTo(mockedCreditView.Object));
        }
    }
}
