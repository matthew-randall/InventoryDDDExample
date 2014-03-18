using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Services.ModelBuilders
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
