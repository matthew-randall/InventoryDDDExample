namespace Inventory.Application.Sales.Credits.CommandDomain.Interface
{
    internal interface ICreditNoteLine
    {
        ISalesInvoiceLine SalesInvoiceLine { get; }
    }
}
