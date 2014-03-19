using System.Collections.Generic;
using Inventory.Application.Sales.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.CommandDomain
{
    internal class SalesInvoice : ISalesInvoice
    {
        private SalesInvoiceDt _salesInvoiceDt;

        public SalesInvoice(SalesInvoiceDt salesInvoiceDt, List<IShipment> shipments)
        {
            _salesInvoiceDt = salesInvoiceDt;
            Shipments = shipments;
        }

        public List<IShipment> Shipments { get; private set; }
        public List<ISalesInvoiceLine> SalesInvoiceLines { get; private set; }
    }
}
