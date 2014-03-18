using System;
using Inventory.Application.Sales.Domain.Interface;

namespace Inventory.Application.Sales.Domain
{
    internal class WarehouseProduct : IWarehouseProduct
    {
        public int WarehouseProductId { get; private set; }
        public string ProductCode { get; private set; }
        public string Description { get; private set; }
        public int StockAvaliable { get; private set; }
        public bool IsNeverDiminishing { get; private set; }
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
