using System;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class CurrencyDt
    {
        public Guid Id { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
    }
}
