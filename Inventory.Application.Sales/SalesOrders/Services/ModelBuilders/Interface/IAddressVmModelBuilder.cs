using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface
{
    internal interface IAddressVmModelBuilder
    {
        AddressVm Build(AddressDt deliveryAddressDt);
    }
}
