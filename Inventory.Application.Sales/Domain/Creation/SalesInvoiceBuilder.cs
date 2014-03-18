using System.Collections.Generic;
using System.Linq;
using Inventory.Application.Sales.Domain.Creation.Interface;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Domain.Creation
{
    internal class SalesInvoiceBuilder : ISalesInvoiceBuilder
    {
        public List<ISalesInvoice> GetSalesInvoices(List<SalesInvoiceDt> salesInvoiceDts, List<IShipment> shipments)
        {
            var salesInvoices = new List<ISalesInvoice>();

            foreach (var salesInvoiceDt in salesInvoiceDts)
            {
                var shipmentsForInvoice = GetShipmentsForInvoice(salesInvoiceDt, shipments);
                salesInvoices.Add(InstantiateSalesInvoice(salesInvoiceDt, shipmentsForInvoice));
            }

            return salesInvoices;
        }

        private List<IShipment> GetShipmentsForInvoice(SalesInvoiceDt salesInvoiceDt, List<IShipment> shipments)
        {
            return shipments.Where(x => x.SalesInvoiceId == salesInvoiceDt.SalesInvoiceId).ToList();
        }

        internal virtual ISalesInvoice InstantiateSalesInvoice(SalesInvoiceDt salesInvoiceDt, List<IShipment> salesInvoiceShipments)
        {
            return new SalesInvoice(salesInvoiceDt, salesInvoiceShipments);
        }
    }
}
