using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders;
using Inventory.Repository.Base.Contracts.Models;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.SalesOrders.Services.ModelBuilders
{
    [TestFixture]
    public class AddressVmModelBuilderTests
    {
        [Test]
        public void Build_Test01()
        {
            var addressDt = new AddressDt()
            {
                Name = "name",
                StreetAddress = "streetAddress",
                Suburb = "Suburb",
                City = "City",
                Country = "Country",
                Region = "Region",
                PostCode = "PostCode"
            };

            var actual = new AddressVmModelBuilder().Build(addressDt);

            Assert.That(actual.City, Is.EqualTo(addressDt.City));
            Assert.That(actual.Country, Is.EqualTo(addressDt.Country));
            Assert.That(actual.Name, Is.EqualTo(addressDt.Name));
            Assert.That(actual.PostCode, Is.EqualTo(addressDt.PostCode));
            Assert.That(actual.Region, Is.EqualTo(addressDt.Region));
            Assert.That(actual.StreetAddress, Is.EqualTo(addressDt.StreetAddress));
            Assert.That(actual.Suburb, Is.EqualTo(addressDt.Suburb));
        }
    }
}
