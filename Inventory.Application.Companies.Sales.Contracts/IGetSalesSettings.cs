using Inventory.Application.Companies.Sales.Contracts.Model;

namespace Inventory.Application.Companies.Sales.Contracts
{
    public interface IGetSalesSettings
    {
        SalesSettings Get();
    }
}
