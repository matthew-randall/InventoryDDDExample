using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.ModelBuilders
{
    internal class CurrencyVmModelBuilder : ICurrencyVmModelBuilder
    {
        public CurrencyVm Build(CurrencyDt currencyDt)
        {
            return new CurrencyVm
            {
                Id = currencyDt.Id,
                CurrencyCode = currencyDt.CurrencyCode,
                Description = currencyDt.Description
            };
        }
    }
}
