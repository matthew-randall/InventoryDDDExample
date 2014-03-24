namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Interface
{
    internal interface IShipmentLine
    {
        IShipment Shipment { get; }
        ISalesInvoiceLine SalesInvoiceLine { get; }
    }
}
