using Inventory.Application.Sales.Credits.QueryDomain.Interfaces;
using Inventory.UI.Sales.Contracts.Credits.Queries;

namespace Inventory.Application.Sales.Credits.Services.ModelBuilders.Interfaces
{
    internal interface ICreditViewQueryModelBuilder
    {
        CreditViewQuery Build(ICreditView creditView);
    }
}
