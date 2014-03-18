using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Sales.Domain.Interface
{
    internal interface ISalesInvoiceLine
    {
        ISalesOrderLine SalesOrderLine { get; }
        ISalesInvoice SalesInvoice { get; }
    }
}
