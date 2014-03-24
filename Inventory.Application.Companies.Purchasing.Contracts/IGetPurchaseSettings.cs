using Inventory.Application.Companies.Purchasing.Contracts.Model;

namespace Inventory.Application.Companies.Purchasing.Contracts
{
    public interface IGetPurchaseSettings
    {
        PurchaseSettings Get();
    }
}
