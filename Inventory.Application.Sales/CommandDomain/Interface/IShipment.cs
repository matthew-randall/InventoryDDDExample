using System;
using System.Collections.Generic;

namespace Inventory.Application.Sales.CommandDomain.Interface
{
    internal interface IShipment
    {
        List<IShipmentLine> ShipmentLines { get; }
        Guid SalesInvoiceId { get; }
    }
}
