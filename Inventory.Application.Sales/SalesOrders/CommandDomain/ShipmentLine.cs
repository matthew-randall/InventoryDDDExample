using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain
{
    internal class ShipmentLine : IShipmentLine
    {
        public IShipment Shipment { get; private set; }
        public ISalesInvoiceLine SalesInvoiceLine { get; private set; }
    }
}
