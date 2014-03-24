using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain
{
    internal class SalesInvoiceLine : ISalesInvoiceLine
    {
        public ISalesOrderLine SalesOrderLine { get; private set; }
        public ISalesInvoice SalesInvoice { get; private set; }
    }
}
