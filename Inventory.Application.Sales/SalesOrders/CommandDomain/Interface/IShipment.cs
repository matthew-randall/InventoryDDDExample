using System;
using System.Collections.Generic;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Interface
{
    internal interface IShipment
    {
        List<IShipmentLine> ShipmentLines { get; }
        Guid SalesInvoiceId { get; }
    }
}
