using Inventory.Application.Sales.CommandDomain.Interface;

namespace Inventory.Application.Sales.CommandDomain
{
    internal class SalesInvoiceLine : ISalesInvoiceLine
    {
        public ISalesOrderLine SalesOrderLine { get; private set; }
        public ISalesInvoice SalesInvoice { get; private set; }
    }
}
