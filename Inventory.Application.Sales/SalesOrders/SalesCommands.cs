using System;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface;
using Inventory.UI.Sales.Contracts.Interfaces.Transactions;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders
{
    public class SalesCommands : ISalesCommands
    {
        public Guid AddNewSalesOrder(string customerCode)
        {
            var customer = InstantiateCustomerBuilder().GetCustomer(customerCode);
            var salesOrderId = InstantiateSalesOrderBuilder().CreateSalesOrder(customer);

            return salesOrderId;
        }

        public SalesOrderVm GetSalesOrder(Guid salesOrderId)
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
