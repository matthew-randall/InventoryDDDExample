using Inventory.Helpers.Structs;

namespace Inventory.UI.Sales.Contracts.Credits.Commands
{
    public class CreditLineViewCommand
    {
        public int LineNumber { get; set; }
        public Code ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public Quantity InvoiceQuantity { get; set; }
        public Monetary InvoicePrice { get; set; }
        public Quantity CreditQuantity { get; set; }
        public Monetary CreditPrice { get; set; }
        public Monetary SubTotal { get; set; }
        public decimal TaxRate { get; set; }
        public string Notes { get; set; }
    }
}
