using System;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class CreditViewLineDt
    {
        public Guid CreditLineId { get; set; }
        public decimal CreditPrice { get; set; }
        public int CreditQuantity { get; set; }
        public decimal TaxRate { get; set; }
    }
}
