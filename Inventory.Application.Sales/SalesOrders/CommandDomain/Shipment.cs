using System;
using System.Collections.Generic;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain
{
    internal class Shipment : IShipment
    {
        private readonly ShipmentDt _shipmentDt;

        public Shipment(ShipmentDt shipmentDt)
        {
            _shipmentDt = shipmentDt;
        }

        public List<IShipmentLine> ShipmentLines { get; private set; }
        public Guid SalesInvoiceId { get; private set; }
    }
}
