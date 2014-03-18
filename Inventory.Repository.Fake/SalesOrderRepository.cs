using System;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.Repository.Fake
{
    public class SalesOrderRepository : ISalesOrderPersistor, ISalesOrderRetriever
    {
        public void AddSalesOrder(SalesOrderDt salesOrderDt)
        {
            
        }

        public SalesOrderDt GetSalesOrderDt(Guid salesOrderId)
        {
            return new SalesOrderDt
            {
                Id = new Guid("37A5A690-6A93-41B2-8692-80ABC5927F7D")
            };
        }
    }
}
