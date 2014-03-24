namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Interface
{
    internal interface ISalesInvoiceLine
    {
        ISalesOrderLine SalesOrderLine { get; }
        ISalesInvoice SalesInvoice { get; }
    }
}
