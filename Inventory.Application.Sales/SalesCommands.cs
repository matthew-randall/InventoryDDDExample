using System;
using Inventory.Application.Sales.Contracts.Interfaces.Transactions;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.CommandDomain.Creation;
using Inventory.Application.Sales.CommandDomain.Creation.Interface;

namespace Inventory.Application.Sales
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
