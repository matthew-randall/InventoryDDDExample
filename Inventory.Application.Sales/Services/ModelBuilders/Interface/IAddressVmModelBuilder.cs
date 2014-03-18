using Inventory.Application.Sales.Contracts.Models;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Services.ModelBuilders.Interface
{
    internal interface IAddressVmModelBuilder
    {
        AddressVm Build(AddressDt deliveryAddressDt);
    }
}
