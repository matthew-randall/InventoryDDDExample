using Inventory.Helpers.Structs;

namespace Inventory.Helpers.Calculators.Interfaces
{
    public interface ILineCalculable
    {
        Monetary Price { get; }
        int Quantity { get; }
        decimal TaxRate { get; }
    }
}
