using System;
using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.Repository.Fake
{
    public class SalesInvoiceRepository : ISalesInvoiceRetriever
    {
        public List<SalesInvoiceDt> GetSalesInvoices(Guid salesOrderId)
        {
            return new List<SalesInvoiceDt>
            {
                new SalesInvoiceDt
                {
                    SalesInvoiceId = new Guid("8D83EC9B-600E-4915-B039-F8C6DAEF896D"),
                    SalesOrderId = new Guid("37A5A690-6A93-41B2-8692-80ABC5927F7D")
                },
                new SalesInvoiceDt 
                { 
                    SalesInvoiceId = new Guid("AC48F1E7-4CEC-4DAB-911E-BDF87311878F"),
                    SalesOrderId = new Guid("37A5A690-6A93-41B2-8692-80ABC5927F7D")
                }
            };
        }
    }
}
