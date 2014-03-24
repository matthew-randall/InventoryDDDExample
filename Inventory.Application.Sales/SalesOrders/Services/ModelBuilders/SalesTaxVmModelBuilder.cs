using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.ModelBuilders
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
