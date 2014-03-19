namespace Inventory.Application.Credits.CommandDomain.Interface
{
    internal interface ICreditNoteLine
    {
        ISalesInvoiceLine SalesInvoiceLine { get; }
    }
}
