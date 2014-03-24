namespace Inventory.Application.Sales.Credits.QueryDomain.Interfaces
{
    internal interface ICreditInitialiser : ICreditView
    {
        void InitialiseLine(ICreditLineView creditLineView);
    }
}
