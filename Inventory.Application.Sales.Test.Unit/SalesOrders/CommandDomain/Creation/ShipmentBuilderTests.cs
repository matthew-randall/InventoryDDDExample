﻿using System.Collections.Generic;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation;
using Inventory.Repository.Base.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.SalesOrders.CommandDomain.Creation
{
    [TestFixture]
    internal class ShipmentBuilderTests
    {
        private Mock<ShipmentBuilder> _mockedShipmentBuilder;
        private ShipmentBuilder _shipmentBuilder;

        [SetUp]
        public void SetUp()
        {
            _mockedShipmentBuilder = new Mock<ShipmentBuilder>();

            _shipmentBuilder = _mockedShipmentBuilder.Object;
        }

        [Test]
        public void GetShipments_Test01_InstantiateShipments()
        {
            var shipmentDts = new List<ShipmentDt>
            {
                new ShipmentDt(),
                new ShipmentDt(),
                new ShipmentDt()
            };

            _shipmentBuilder.GetShipments(shipmentDts);

            _mockedShipmentBuilder.Verify(x => x.InstantiateShipment(shipmentDts[0]), Times.Once);
            _mockedShipmentBuilder.Verify(x => x.InstantiateShipment(shipmentDts[1]), Times.Once);
            _mockedShipmentBuilder.Verify(x => x.InstantiateShipment(shipmentDts[2]), Times.Once);
        }
    }
}
