using System;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Sales.Contracts.Interface
{
    public interface ISalesOrderRetriever
    {
        SalesOrderDt GetSalesOrderDt(Guid salesOrderId);
    }
}
