using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface
{
    internal interface ISalesOrderDtModelBuilder
    {
        SalesOrderDt Create(ICustomer customer);
    }
}
