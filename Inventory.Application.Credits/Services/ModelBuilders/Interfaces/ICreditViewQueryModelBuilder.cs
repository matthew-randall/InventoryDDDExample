using Inventory.Application.Credits.Contracts.Queries;
using Inventory.Application.Credits.QueryDomain.Interfaces;

namespace Inventory.Application.Credits.Services.ModelBuilders.Interfaces
{
    internal interface ICreditViewQueryModelBuilder
    {
        CreditViewQuery Build(ICreditView creditView);
    }
}
