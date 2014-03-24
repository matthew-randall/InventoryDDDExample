using Inventory.Helpers.Calculators;
using Inventory.Helpers.Calculators.Interfaces;
using Moq;
using NUnit.Framework;

namespace Inventory.Helpers.Tests.Unit.Calculators
{
    [TestFixture]
    public class LineCalculatorTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void CalculateSubTotal_Test01()
        {
            var mockedCalculable = new Mock<ILineCalculable>();

            mockedCalculable.Setup(x => x.Price).Returns(9.99m);
            mockedCalculable.Setup(x => x.Quantity).Returns(5);

            var result = LineCalculator.SubTotal(mockedCalculable.Object);

            Assert.That(result == 49.95m);
        }

        [Test]
        public void CalculateTaxTotal_Test01()
        {
            var mockedCalculable = new Mock<ILineCalculable>();

            mockedCalculable.Setup(x => x.Price).Returns(9.99m);
            mockedCalculable.Setup(x => x.Quantity).Returns(1);
            mockedCalculable.Setup(x => x.TaxRate).Returns(0.99m);

            var result = LineCalculator.TaxTotal(mockedCalculable.Object);

            Assert.That(result == 9.8901m);
        }

        [Test]
        public void CalculateTaxTotal_Test02()
        {
            var mockedCalculable = new Mock<ILineCalculable>();

            mockedCalculable.Setup(x => x.Price).Returns(9.99m);
            mockedCalculable.Setup(x => x.Quantity).Returns(10);
            mockedCalculable.Setup(x => x.TaxRate).Returns(0.99m);

            var result = LineCalculator.TaxTotal(mockedCalculable.Object);

            Assert.That(result == 98.901m);
        }

        [Test]
        public void CalculateTotal_Test01()
        {
            var mockedCalculable = new Mock<ILineCalculable>();

            mockedCalculable.Setup(x => x.Price).Returns(9.99m);
            mockedCalculable.Setup(x => x.Quantity).Returns(1);
            mockedCalculable.Setup(x => x.TaxRate).Returns(0.99m);

            var result = LineCalculator.Total(mockedCalculable.Object);

            Assert.That(result == 19.8801m);
        }

        [Test]
        public void CalculateTotal_Test02()
        {
            var mockedCalculable = new Mock<ILineCalculable>();

            mockedCalculable.Setup(x => x.Price).Returns(9.99m);
            mockedCalculable.Setup(x => x.Quantity).Returns(20);
            mockedCalculable.Setup(x => x.TaxRate).Returns(0.99m);

            var result = LineCalculator.Total(mockedCalculable.Object);

            Assert.That(result == 397.602m);
        }
    }
}
