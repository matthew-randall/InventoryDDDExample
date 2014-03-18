using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Sales.Domain.Interface
{
    internal interface IWarehouseProduct
    {
        int WarehouseProductId { get; }
        string ProductCode { get; }
        string Description { get; }
        int StockAvaliable { get; }
        bool IsNeverDiminishing { get; }
        void AllocateStock();
        void DeallocateStock();
    }
}
