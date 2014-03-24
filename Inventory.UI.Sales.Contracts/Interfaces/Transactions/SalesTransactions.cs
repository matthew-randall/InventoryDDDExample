using System;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.UI.Sales.Contracts.Interfaces.Transactions
{
    public interface ISalesCommands
    {
        Guid AddNewSalesOrder(string customerCode);
        SalesOrderVm GetSalesOrder(Guid salesOrderId);
    }
}
