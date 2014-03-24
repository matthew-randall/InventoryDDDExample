using System.Collections.Generic;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Interface
{
    internal interface ISalesInvoice
    {
        List<IShipment> Shipments { get; }
        List<ISalesInvoiceLine> SalesInvoiceLines { get; }
    }
}
