using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Domain.Interface;

namespace Inventory.Application.Sales.Services.Builders.Interface
{
    internal interface ISalesOrderVmBuilder
    {
        SalesOrderVm Build(ISalesOrder salesOrder);
    }
}
