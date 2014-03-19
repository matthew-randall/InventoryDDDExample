using Inventory.Application.Sales.CommandDomain.Interface;

namespace Inventory.Application.Sales.CommandDomain.Creation.Interface
{
    internal interface ICustomerBuilder
    {
        ICustomer GetCustomer(string customerCode);
    }
}
