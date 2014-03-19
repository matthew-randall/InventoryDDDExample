using System;
using Inventory.Application.Sales.CommandDomain.Interface;

namespace Inventory.Application.Sales.CommandDomain.Creation.Interface
{
    internal interface ISalesOrderBuilder
    {
        Guid CreateSalesOrder(ICustomer customer);
        ISalesOrder GetSalesOrder(Guid salesOrderId);
    }
}
