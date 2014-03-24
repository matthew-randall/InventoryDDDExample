using System;

namespace Inventory.UI.Sales.Contracts.Models
{
    public class SalesTaxVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
        public string TaxType { get; set; }
    }
}
