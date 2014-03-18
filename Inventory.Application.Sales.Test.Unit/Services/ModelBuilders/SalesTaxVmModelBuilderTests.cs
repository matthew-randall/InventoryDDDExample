using System;
using NUnit.Framework;
using Inventory.Application.Sales.Services.ModelBuilders;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Test.Unit.Services.ModelBuilders
{
    [TestFixture]
    public class SalesTaxVmModelBuilderTests
    {
        [Test]
        public void Build_Test01()
        {
            var salesTax = new SalesTaxDt
            {
                Id = Guid.NewGuid(),
                Name = "Name",
                TaxRate = 123.43m,
                TaxType = "type"
            };

            var actual = new SalesTaxVmModelBuilder().Build(salesTax);

            Assert.That(actual.Id == salesTax.Id);
            Assert.That(actual.Name == salesTax.Name);
            Assert.That(actual.TaxRate == salesTax.TaxRate);
            Assert.That(actual.TaxType == salesTax.TaxType);
        }
    }
}
