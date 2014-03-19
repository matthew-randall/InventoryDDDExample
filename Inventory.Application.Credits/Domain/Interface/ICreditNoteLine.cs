namespace Inventory.Application.Credits.Domain.Interface
{
    internal interface ICreditNoteLine
    {
        ISalesInvoiceLine SalesInvoiceLine { get; }
    }
}
