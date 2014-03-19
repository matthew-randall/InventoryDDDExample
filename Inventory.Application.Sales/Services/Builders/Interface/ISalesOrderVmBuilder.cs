using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.CommandDomain.Interface;

namespace Inventory.Application.Sales.Services.Builders.Interface
{
    internal interface ISalesOrderVmBuilder
    {
        SalesOrderVm Build(ISalesOrder salesOrder);
    }
}
