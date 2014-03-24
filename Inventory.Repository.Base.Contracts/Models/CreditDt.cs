using System;
using Inventory.Helpers.Enum;
using Inventory.Repository.Base.Contracts.Enum;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class CreditDt
    {
        public CreditType CreditType { get; set; }
        public CreditStatus Status { get; set; }
        public string Notes { get; set; }
        public DateTime CreditDate { get; set; }
        public Guid CreditId { get; set; }
        public string CreditNumber { get; set; }
    }
}
