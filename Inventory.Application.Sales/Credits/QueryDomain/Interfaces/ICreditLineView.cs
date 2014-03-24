using Inventory.Helpers.Structs;

namespace Inventory.Application.Sales.Credits.QueryDomain.Interfaces
{
    internal interface ICreditLineView
    {
        ICreditView CreditView { get; }
        Monetary Price { get; }
        Monetary Total { get; }
    }
}
