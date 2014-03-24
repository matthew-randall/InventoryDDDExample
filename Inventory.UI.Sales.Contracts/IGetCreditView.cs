using System;
using Inventory.UI.Sales.Contracts.Credits.Commands;

namespace Inventory.UI.Sales.Contracts
{
    public interface IGetCreditView
    {
        CreditViewCommand Get(Guid creditId);
    }
}
