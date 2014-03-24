using System;
using Inventory.UI.Sales.Contracts.Credits.Commands;

namespace Inventory.UI.Sales.Contracts.Credits.Interface
{
    public interface ICreditCommands
    {
        CreditViewCommand GetCreditView(Guid creditId);
    }
}
