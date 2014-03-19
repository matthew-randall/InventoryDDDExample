namespace Inventory.Application.Sales.CommandDomain.Interface
{
    internal interface IShipmentLine
    {
        IShipment Shipment { get; }
        ISalesInvoiceLine SalesInvoiceLine { get; }
    }
}
