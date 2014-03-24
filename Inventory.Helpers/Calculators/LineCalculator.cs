using Inventory.Helpers.Calculators.Interfaces;
using Inventory.Helpers.Structs;

namespace Inventory.Helpers.Calculators
{
    public static class LineCalculator
    {
        public static Monetary SubTotal(ILineCalculable lineCalculable)
        {
            return lineCalculable.Price * lineCalculable.Quantity;
        }

        public static Monetary TaxTotal(ILineCalculable lineCalculable)
        {
            return SubTotal(lineCalculable) * lineCalculable.TaxRate;
        }

        public static Monetary Total(ILineCalculable lineCalculable)
        {
            return SubTotal(lineCalculable) + TaxTotal(lineCalculable);
        }
    }
}
