using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.Builders.Interface
{
    internal interface ISalesOrderVmBuilder
    {
        SalesOrderVm Build(ISalesOrder salesOrder);
    }
}
