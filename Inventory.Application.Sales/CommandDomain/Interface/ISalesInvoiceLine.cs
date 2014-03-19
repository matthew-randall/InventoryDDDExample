namespace Inventory.Application.Sales.CommandDomain.Interface
{
    internal interface ISalesInvoiceLine
    {
        ISalesOrderLine SalesOrderLine { get; }
        ISalesInvoice SalesInvoice { get; }
    }
}
