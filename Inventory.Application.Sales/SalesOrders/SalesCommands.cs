using System;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface;
using Inventory.UI.Sales.Contracts;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders
{
    public class SalesCommands : IGetSalesOrderVm, IAddNewSalesOrder
    {
        public Guid Add(string customerCode)
        {
            var customer = InstantiateCustomerBuilder().GetCustomer(customerCode);
            var salesOrderId = InstantiateSalesOrderBuilder().CreateSalesOrder(customer);

            return salesOrderId;
        }

        public SalesOrderVm Get(Guid salesOrderId)
        {
            var salesOrder = InstantiateSalesOrderBuilder().GetSalesOrder(salesOrderId);
            return salesOrder.GetSalesOrderVm();
        }

        internal virtual ICustomerBuilder InstantiateCustomerBuilder()
        {
            return new CustomerBuilder();
        }

        internal virtual ISalesOrderBuilder InstantiateSalesOrderBuilder()
        {
            return new SalesOrderBuilder();
        }
    }
}
