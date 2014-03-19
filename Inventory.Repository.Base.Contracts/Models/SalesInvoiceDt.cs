using System;
using Inventory.Repository.Base.Contracts.Enum;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class SalesInvoiceDt
    {
        public Guid SalesInvoiceId { get; set; }
        public Guid SalesOrderId { get; set; }
        public string Notes { get; set; }
        public decimal TaxRate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CustomerRef { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string InvoiceNumber { get; set; }
        public SalesInvoiceStatus InvoiceStatus { get; set; }
    }
}
