using System;
using Inventory.Application.Sales.Contracts.Interfaces.Transactions;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Domain.Creation;
using Inventory.Application.Sales.Domain.Creation.Interface;

namespace Inventory.Application.Sales.Transactions
{
    public class SalesTransactions : ISalesTransactions
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
