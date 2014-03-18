using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Sales.Domain.Interface
{
    internal interface IShipmentLine
    {
        IShipment Shipment { get; }
        ISalesInvoiceLine SalesInvoiceLine { get; }
    }
}
