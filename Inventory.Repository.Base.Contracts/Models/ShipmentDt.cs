using System;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class ShipmentDt
    {
        public Guid SalesInvoiceId { get; set; }
        public Guid ShipmentId { get; set; }
    }
}
