using System.Collections.Generic;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface
{
    internal interface IShipmentBuilder
    {
        List<IShipment> GetShipments(List<ShipmentDt> shipments);
    }
}
