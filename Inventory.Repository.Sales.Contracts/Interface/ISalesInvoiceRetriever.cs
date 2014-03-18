using System;
using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Sales.Contracts.Interface
{
    public interface ISalesInvoiceRetriever
    {
        List<SalesInvoiceDt> GetSalesInvoices(Guid salesOrderId);
    }
}
