using System;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class CreditLineDt
    {
        public Guid CreditLineId { get; set; }
        public decimal CreditPrice { get; set; }
        public int CreditQuantity { get; set; }
        public decimal TaxRate { get; set; }
        public int LineNumber { get; set; }
        public bool ReturnToStock { get; set; }
        public string Notes { get; set; }
        public Guid CreditReasonDtId { get; set; }
    }
}
