using System;

namespace Inventory.UI.Sales.Contracts
{
    public interface IAddNewSalesOrder
    {
        Guid Add(string customerCode);
    }
}
