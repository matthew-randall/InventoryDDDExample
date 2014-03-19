using Inventory.Application.Sales.CommandDomain.Interface;

namespace Inventory.Application.Sales.CommandDomain
{
    internal class ShipmentLine : IShipmentLine
    {
        public IShipment Shipment { get; private set; }
        public ISalesInvoiceLine SalesInvoiceLine { get; private set; }
    }
}
