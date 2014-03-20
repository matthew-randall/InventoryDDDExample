namespace Inventory.Application.Credits.QueryDomain.Interfaces
{
    internal interface ICreditLineInitialiser : ICreditLineView
    {
        void Initialise(ICreditView creditView);
    }
}
