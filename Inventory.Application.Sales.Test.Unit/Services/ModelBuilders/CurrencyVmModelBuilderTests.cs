using System;
using NUnit.Framework;
using Inventory.Application.Sales.Services.ModelBuilders;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Tests.Unit.Services.ModelBuilders
{
    [TestFixture]
    public class CurrencyVmModelBuilderTests
    {
        [Test]
        public void Build_Test01()
        {
            var currencyDt = new CurrencyDt
            {
                Id = Guid.NewGuid(),
                CurrencyCode = "CODE",
                Description = "DESC"
            };

            var actual = new CurrencyVmModelBuilder().Build(currencyDt);
            
            Assert.That(actual.Id == currencyDt.Id);
            Assert.That(actual.CurrencyCode == currencyDt.CurrencyCode);
            Assert.That(actual.Description == currencyDt.Description);

        }
    }
}
