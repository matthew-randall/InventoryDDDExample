using System;
using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders;
using Inventory.Repository.Base.Contracts.Models;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.SalesOrders.Services.ModelBuilders
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
                TaxRate = 0.12343m,
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
