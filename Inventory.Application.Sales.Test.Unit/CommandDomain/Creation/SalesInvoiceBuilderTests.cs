using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Inventory.Application.Sales.CommandDomain.Creation;
using Inventory.Application.Sales.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Tests.Unit.CommandDomain.Creation
{
    [TestFixture]
    public class SalesInvoiceBuilderTests
    {
        private Mock<SalesInvoiceBuilder> _mockedSalesInvoiceBuilder;
        private SalesInvoiceBuilder _salesInvoiceBuilder;

        [SetUp]
        public void SetUp()
        {
            _mockedSalesInvoiceBuilder = new Mock<SalesInvoiceBuilder>();

            _salesInvoiceBuilder = _mockedSalesInvoiceBuilder.Object;
        }

        [Test]
        public void GetSalesInvoices_Test01_InstantiateSalesInvoice()
        {
            var salesInvoiceDts = new List<SalesInvoiceDt>
            {
                new SalesInvoiceDt(),
                new SalesInvoiceDt(),
                new SalesInvoiceDt()
            };

            _salesInvoiceBuilder.GetSalesInvoices(salesInvoiceDts, new List<IShipment>());

            _mockedSalesInvoiceBuilder.Verify(x => x.InstantiateSalesInvoice(salesInvoiceDts[0], It.IsAny<List<IShipment>>()), Times.Once);
            _mockedSalesInvoiceBuilder.Verify(x => x.InstantiateSalesInvoice(salesInvoiceDts[1], It.IsAny<List<IShipment>>()), Times.Once);
            _mockedSalesInvoiceBuilder.Verify(x => x.InstantiateSalesInvoice(salesInvoiceDts[2], It.IsAny<List<IShipment>>()), Times.Once);
        }

        [Test]
        public void GetSalesInvoices_Test02_ReturnListOfInstantiatedSalesInvoices()
        {
            var salesInvoiceDts = new List<SalesInvoiceDt>
            {
                new SalesInvoiceDt(),
                new SalesInvoiceDt(),
                new SalesInvoiceDt()
            };

            var salesInvoices = _salesInvoiceBuilder.GetSalesInvoices(salesInvoiceDts, new List<IShipment>());

            Assert.That(salesInvoices.Count == 3);
        }

        [Test]
        public void GetSalesInvoices_Test03_InstantiateSalesInvoicesUsingRelatedShipments()
        {
            var invoiceId1 = Guid.NewGuid();
            var invoiceId2 = Guid.NewGuid();

            var salesInvoiceDts = new List<SalesInvoiceDt>
            {
                new SalesInvoiceDt { SalesInvoiceId = invoiceId1 },
                new SalesInvoiceDt { SalesInvoiceId = invoiceId2 }
            };

            var mockedShipment1 = new Mock<IShipment>();
            var mockedShipment2 = new Mock<IShipment>();
            var mockedShipment3 = new Mock<IShipment>();
            var mockedShipment4 = new Mock<IShipment>();
            var mockedShipment5 = new Mock<IShipment>();

            mockedShipment1.Setup(x => x.SalesInvoiceId).Returns(invoiceId1);
            mockedShipment2.Setup(x => x.SalesInvoiceId).Returns(invoiceId1);
            mockedShipment3.Setup(x => x.SalesInvoiceId).Returns(invoiceId2);
            mockedShipment4.Setup(x => x.SalesInvoiceId).Returns(invoiceId2);
            mockedShipment5.Setup(x => x.SalesInvoiceId).Returns(invoiceId2);

            var shipments = new List<IShipment>
            {
                mockedShipment1.Object,
                mockedShipment2.Object,
                mockedShipment3.Object,
                mockedShipment4.Object,
                mockedShipment5.Object,
            };

            _mockedSalesInvoiceBuilder.Setup(
                x => x.InstantiateSalesInvoice(It.IsAny<SalesInvoiceDt>(), It.IsAny<List<IShipment>>())).Callback<SalesInvoiceDt, List<IShipment>>(
                    (salesInvoiceDtParam, shipmentsParam) =>
                    {
                        foreach (var shipment in shipmentsParam)
                            Assert.That(shipment.SalesInvoiceId, Is.EqualTo(salesInvoiceDtParam.SalesInvoiceId));
                    });

            _salesInvoiceBuilder.GetSalesInvoices(salesInvoiceDts, shipments);
        }
    }
}
