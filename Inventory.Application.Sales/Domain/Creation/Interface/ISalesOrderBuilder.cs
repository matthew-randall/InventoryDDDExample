using System;
using Inventory.Application.Sales.Domain.Interface;

namespace Inventory.Application.Sales.Domain.Creation.Interface
{
    internal interface ISalesOrderBuilder
    {
        Guid CreateSalesOrder(ICustomer customer);
        ISalesOrder GetSalesOrder(Guid salesOrderId);
    }
}
