using System.Collections.Generic;
using System.Linq;
using Inventory.Application.Sales.Domain.Creation.Interface;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Domain.Creation
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
