using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.CommandDomain.Interface;

namespace Inventory.Application.Sales.Services.ModelBuilders.Interface
{
    internal interface ISalesOrderVmModelBuilder
    {
        SalesOrderVm Build(ISalesOrder salesOrder);
    }
}
