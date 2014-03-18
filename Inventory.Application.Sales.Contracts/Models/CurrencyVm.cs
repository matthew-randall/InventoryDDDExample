using System;

namespace Inventory.Application.Sales.Contracts.Models
{
    public class CurrencyVm
    {
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
    }
}
