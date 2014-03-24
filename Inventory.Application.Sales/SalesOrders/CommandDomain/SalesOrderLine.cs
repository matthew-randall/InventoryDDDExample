using System;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain
{
    internal class SalesOrderLine : ISalesOrderLine
    {
        public int SalesOrderLineId { get; private set; }
        public int LineNumber { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal DiscountRate { get; private set; }
        public decimal DiscountPrice { get; private set; }
        public decimal TaxRate { get; private set; }
        public decimal Total { get; private set; }
        public decimal Margin { get; private set; }
        public IWarehouseProduct WarehouseProduct { get; private set; }
        public ISalesOrder SalesOrder { get; private set; }
        public bool IsStockAllocated { get; private set; }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }

        public void AllocateStock()
        {
            throw new NotImplementedException();
        }

        public void DeallocateStock()
        {
            throw new NotImplementedException();
        }
    }
}
