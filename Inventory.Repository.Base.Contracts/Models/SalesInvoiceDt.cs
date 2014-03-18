using System;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class SalesInvoiceDt
    {
        public Guid SalesInvoiceId { get; set; }
        public Guid SalesOrderId { get; set; }
    }
}
