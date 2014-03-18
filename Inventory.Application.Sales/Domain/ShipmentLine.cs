using Inventory.Application.Sales.Domain.Interface;

namespace Inventory.Application.Sales.Domain
{
    internal class ShipmentLine : IShipmentLine
    {
        public IShipment Shipment { get; private set; }
        public ISalesInvoiceLine SalesInvoiceLine { get; private set; }
    }
}
