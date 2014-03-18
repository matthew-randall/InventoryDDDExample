using System;
using System.Collections.Generic;

namespace Inventory.Application.Sales.Domain.Interface
{
    internal interface IShipment
    {
        List<IShipmentLine> ShipmentLines { get; }
        Guid SalesInvoiceId { get; }
    }
}
