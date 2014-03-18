using Inventory.Application.Sales.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Domain.Creation.Interface
{
    internal interface ICustomerBuilder
    {
        ICustomer GetCustomer(string customerCode);
    }
}
