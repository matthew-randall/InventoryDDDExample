using System;
using Inventory.Repository.Base.Contracts.Enum;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class SalesOrderDt
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public SalesOrderStatus SalesOrderStatus { get; set; }
        public Guid CustomerId { get; set; }
        public WarehouseDt Warehouse { get; set; }
        public CurrencyDt Currency { get; set; }
    }
}
