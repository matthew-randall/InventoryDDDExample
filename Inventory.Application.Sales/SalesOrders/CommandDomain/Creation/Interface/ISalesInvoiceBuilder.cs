using System.Collections.Generic;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface
{
    internal interface ISalesInvoiceBuilder
    {
        List<ISalesInvoice> GetSalesInvoices(List<SalesInvoiceDt> salesInvoiceDts, List<IShipment> shipments);
    }
}
