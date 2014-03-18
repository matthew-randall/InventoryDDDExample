using System;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Services.ModelBuilders
{
    internal class SalesTaxVmModelBuilder : ISalesTaxVmModelBuilder
    {
        public SalesTaxVm Build(SalesTaxDt salesTax)
        {
            return new SalesTaxVm
            {
                Id = salesTax.Id,
                Name = salesTax.Name,
                TaxRate = salesTax.TaxRate,
                TaxType = salesTax.TaxType
            };
        }
    }
}
