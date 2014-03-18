using System.Collections.Generic;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Domain.Creation.Interface
{
    internal interface ISalesInvoiceBuilder
    {
        List<ISalesInvoice> GetSalesInvoices(List<SalesInvoiceDt> salesInvoiceDts, List<IShipment> shipments);
    }
}
