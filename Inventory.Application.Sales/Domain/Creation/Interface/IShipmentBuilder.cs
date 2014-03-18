using System.Collections.Generic;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Domain.Creation.Interface
{
    internal interface IShipmentBuilder
    {
        List<IShipment> GetShipments(List<ShipmentDt> shipments);
    }
}
