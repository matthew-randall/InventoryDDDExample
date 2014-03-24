using System;
using System.Collections.Generic;
using Inventory.Helpers.Enum;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class CreditViewDt
    {
        public Guid CreditId { get; set; }
        public string CreditNumber { get; set; }
        public string CustomerCode { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime CreditDate { get; set; }
        public string CustomerName { get; set; }
        public CreditStatus Status { get; set; }
        public List<CreditViewLineDt> CreditViewLines { get; set; }
    }
}
