using System;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.UI.Sales.Contracts
{
    public interface IGetSalesOrderVm
    {
        SalesOrderVm Get(Guid salesOrderId);
    }
}
