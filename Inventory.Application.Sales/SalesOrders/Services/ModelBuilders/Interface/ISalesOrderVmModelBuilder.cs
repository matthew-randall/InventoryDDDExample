using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface
{
    internal interface ISalesOrderVmModelBuilder
    {
        SalesOrderVm Build(ISalesOrder salesOrder);
    }
}
