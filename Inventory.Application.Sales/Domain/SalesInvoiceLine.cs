using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Application.Sales.Domain.Interface;

namespace Inventory.Application.Sales.Domain
{
    internal class SalesInvoiceLine : ISalesInvoiceLine
    {
        public ISalesOrderLine SalesOrderLine { get; private set; }
        public ISalesInvoice SalesInvoice { get; private set; }
    }
}
