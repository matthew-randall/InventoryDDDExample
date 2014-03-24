using System.Collections.Generic;
using System.Linq;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Creation
{
    internal class ShipmentBuilder : IShipmentBuilder
    {
        public List<IShipment> GetShipments(List<ShipmentDt> shipments)
        {
            return shipments.Select(InstantiateShipment).ToList();
        }

        internal virtual IShipment InstantiateShipment(ShipmentDt shipmentDt)
        {
            return new Shipment(shipmentDt);
        }
    }
}
