using System;
using Inventory.Application.Sales.Contracts.Models;

namespace Inventory.Application.Sales.Contracts.Interfaces.Transactions
{
    public interface ISalesTransactions
    {
        Guid AddNewSalesOrder(string customerCode);
        SalesOrderVm GetSalesOrder(Guid salesOrderId);
    }
}
