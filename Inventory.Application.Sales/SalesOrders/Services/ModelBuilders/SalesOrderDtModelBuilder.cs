using System;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.ModelBuilders
{
    internal class SalesOrderDtModelBuilder : ISalesOrderDtModelBuilder
    {
        public SalesOrderDt Create(ICustomer customer)
        {
            var dt = CreateNewSalesOrderDt();

            AssignCustomerValues(customer, dt);
            
            return dt;
        }

        private static SalesOrderDt CreateNewSalesOrderDt()
        {
            return new SalesOrderDt
            {
                Id = Guid.NewGuid(),
                OrderDate = DateTime.UtcNow,
                RequiredDate = DateTime.UtcNow,
                SalesOrderStatus = SalesOrderStatus.Parked
            };
        }

        private static void AssignCustomerValues(ICustomer customer, SalesOrderDt salesOrderDt)
        {
            salesOrderDt.Currency = customer.Currency;
            salesOrderDt.CustomerId = customer.CustomerId;
            salesOrderDt.Warehouse = customer.Warehouse;
        }
    }
}
