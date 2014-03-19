using System.Collections.Generic;

namespace Inventory.Application.Sales.CommandDomain.Interface
{
    internal interface ISalesInvoice
    {
        List<IShipment> Shipments { get; }
        List<ISalesInvoiceLine> SalesInvoiceLines { get; }
    }
}
