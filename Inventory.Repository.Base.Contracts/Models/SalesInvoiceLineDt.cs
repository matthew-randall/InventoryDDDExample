using System;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class SalesInvoiceLineDt
    {
        public Guid SalesInvoiceLineId { get; set; }

        public decimal InvoiceQuantity { get; set; }

        public decimal UnitPrice { get; set; }

        public string Notes { get; set; }

        public ProductDt ProductDt { get; set; }
    }
}
