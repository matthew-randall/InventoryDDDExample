using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface
{
    internal interface ICustomerBuilder
    {
        ICustomer GetCustomer(string customerCode);
    }
}
