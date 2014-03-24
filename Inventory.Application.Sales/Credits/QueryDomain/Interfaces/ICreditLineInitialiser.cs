namespace Inventory.Application.Sales.Credits.QueryDomain.Interfaces
{
    internal interface ICreditLineInitialiser : ICreditLineView
    {
        void Initialise(ICreditView creditView);
    }
}
