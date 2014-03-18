using Inventory.Application.Sales.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Services.ModelBuilders.Interface
{
    internal interface ISalesOrderDtModelBuilder
    {
        SalesOrderDt Create(ICustomer customer);
    }
}
