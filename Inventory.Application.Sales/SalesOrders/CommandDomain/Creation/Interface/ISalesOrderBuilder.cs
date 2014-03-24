using System;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface
{
    internal interface ISalesOrderBuilder
    {
        Guid CreateSalesOrder(ICustomer customer);
        ISalesOrder GetSalesOrder(Guid salesOrderId);
    }
}
