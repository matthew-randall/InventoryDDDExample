using NUnit.Framework;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Services.ModelBuilders;
using Inventory.Application.Sales.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Tests.Unit.Services.ModelBuilders
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
