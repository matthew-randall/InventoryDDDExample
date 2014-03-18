using System;
using System.Collections.Generic;
using Moq;
using Ninject;
using NUnit.Framework;
using Inventory.Application.Sales.Domain.Creation;
using Inventory.Application.Sales.Domain.Creation.Interface;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Application.Sales.Services.ModelBuilders.Interface;
using Inventory.DependencyInjector;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.Application.Sales.Test.Unit.Domain.Creation
{
    [TestFixture]
    public class SalesOrderBuilderTests
    {
        private Mock<SalesOrderBuilder> _mockedSalesOrderBuilder;
        private SalesOrderBuilder _salesOrderBuilder;
        private Mock<ICustomer> _mockedCustomer;
        private Mock<ISalesOrderDtModelBuilder> _mockedSalesOrderDtBuilder;
        private Mock<ISalesOrderPersistor> _mockedSalesOrderPersistor;
        private SalesOrderDt _salesOrderDt;
        private Mock<ISalesOrderRetriever> _mockedSalesOrderRetriever;
        private Mock<ISalesInvoiceRetriever> _mockedSalesInvoiceRetriever;
        private Mock<IShipmentRetriever> _mockedShipmentRetriever;
        private Mock<IShipmentBuilder> _mockedShipmentBuilder;
        private Mock<ISalesInvoiceBuilder> _mockedSalesInvoiceBuilder;

        [SetUp]
        public void SetUp()
        {

            _salesOrderDt = new SalesOrderDt { Id = Guid.NewGuid() };

            _mockedCustomer = new Mock<ICustomer>();
            
            _mockedSalesOrderDtBuilder = new Mock<ISalesOrderDtModelBuilder>();
            _mockedSalesOrderPersistor = new Mock<ISalesOrderPersistor>();
            _mockedSalesOrderRetriever = new Mock<ISalesOrderRetriever>();
            _mockedSalesInvoiceRetriever = new Mock<ISalesInvoiceRetriever>();
            _mockedShipmentRetriever = new Mock<IShipmentRetriever>();

            _mockedShipmentBuilder = new Mock<IShipmentBuilder>();
            _mockedSalesInvoiceBuilder = new Mock<ISalesInvoiceBuilder>();

            _mockedSalesOrderDtBuilder.Setup(x => x.Create(_mockedCustomer.Object)).Returns(_salesOrderDt);

            _mockedSalesOrderBuilder = new Mock<SalesOrderBuilder>();
            _mockedSalesOrderBuilder.Setup(x => x.InstantiateSalesOrderDtBuilder())
                .Returns(_mockedSalesOrderDtBuilder.Object);
            _mockedSalesOrderBuilder.Setup(x => x.InstantiateShipmentBuilder())
                .Returns(_mockedShipmentBuilder.Object);
            _mockedSalesOrderBuilder.Setup(x => x.InstantiateSalesInvoiceBuilder())
                .Returns(_mockedSalesInvoiceBuilder.Object);
            _mockedSalesInvoiceRetriever.Setup(x => x.GetSalesInvoices(It.IsAny<Guid>()))
                .Returns(new List<SalesInvoiceDt>());
            
            IKernel kernel = new StandardKernel();

            kernel.Bind<ISalesOrderPersistor>().ToConstant(_mockedSalesOrderPersistor.Object);
            kernel.Bind<ISalesOrderRetriever>().ToConstant(_mockedSalesOrderRetriever.Object);
            kernel.Bind<ISalesInvoiceRetriever>().ToConstant(_mockedSalesInvoiceRetriever.Object);
            kernel.Bind<IShipmentRetriever>().ToConstant(_mockedShipmentRetriever.Object);

            NinjectDependencyInjector.Instance.Initialize(kernel);
            
            _salesOrderBuilder = _mockedSalesOrderBuilder.Object;
        }

        [Test]
        public void CreateSalesOrder_Test01_BuildObjectFromCustomer()
        {
            _salesOrderBuilder.CreateSalesOrder(_mockedCustomer.Object);
            
            _mockedSalesOrderDtBuilder.Verify(x => x.Create(_mockedCustomer.Object), Times.Once);
        }

        [Test]
        public void CreateSalesOrder_Test02_PersistCreatedObject()
        {
            _salesOrderBuilder.CreateSalesOrder(_mockedCustomer.Object);

            _mockedSalesOrderPersistor.Verify(x => x.AddSalesOrder(_salesOrderDt), Times.Once);
        }

        [Test]
        public void CreateSalesOrder_Test03_ReturnNewId()
        {
            _mockedSalesOrderDtBuilder.Setup(x => x.Create(_mockedCustomer.Object)).Returns(_salesOrderDt);

            var newId = _salesOrderBuilder.CreateSalesOrder(_mockedCustomer.Object);

            Assert.That(newId, Is.EqualTo(_salesOrderDt.Id));
        }

        [Test]
        public void GetSalesOrder_Test01_GetSalesOrderFromRepository()
        {
            var id = Guid.NewGuid();
            _salesOrderBuilder.GetSalesOrder(id);

            _mockedSalesOrderRetriever.Verify(x => x.GetSalesOrderDt(id), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test02_GetSalesInvoicesFromRepository()
        {
            var id = Guid.NewGuid();
            _salesOrderBuilder.GetSalesOrder(id);
            _mockedSalesInvoiceRetriever.Verify(x => x.GetSalesInvoices(id), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test03_GetShipmentsFromRepository()
        {
            var salesInvoices = new List<SalesInvoiceDt>
            {
                new SalesInvoiceDt { SalesInvoiceId = Guid.NewGuid() },
                new SalesInvoiceDt { SalesInvoiceId = Guid.NewGuid() },
                new SalesInvoiceDt { SalesInvoiceId = Guid.NewGuid() },
            };

            Guid[] selectOnGuids = null;

            _mockedSalesInvoiceRetriever.Setup(x => x.GetSalesInvoices(It.IsAny<Guid>()))
                .Returns(salesInvoices);

            _mockedShipmentRetriever.Setup(x => x.GetShipmentsForInvoices(It.IsAny<Guid[]>())).Callback<Guid[]>(x => selectOnGuids = x);

            var id = Guid.NewGuid();
            _salesOrderBuilder.GetSalesOrder(id);

            Assert.That(selectOnGuids[0], Is.EqualTo(salesInvoices[0].SalesInvoiceId));
            Assert.That(selectOnGuids[1], Is.EqualTo(salesInvoices[1].SalesInvoiceId));
            Assert.That(selectOnGuids[2], Is.EqualTo(salesInvoices[2].SalesInvoiceId));
        }

        [Test]
        public void GetSalesOrder_Test04_InstantiateShipmentBuilder()
        {
            _salesOrderBuilder.GetSalesOrder(Guid.NewGuid());

            _mockedSalesOrderBuilder.Verify(x => x.InstantiateShipmentBuilder(), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test05_GetShipmentsFromBuilder()
        {
            var shipments = new List<ShipmentDt>
            {
                new ShipmentDt(),
                new ShipmentDt(),
                new ShipmentDt(),
            };

            _mockedShipmentRetriever.Setup(x => x.GetShipmentsForInvoices(It.IsAny<Guid[]>()))
                .Returns(shipments);

            _salesOrderBuilder.GetSalesOrder(Guid.NewGuid());

            _mockedShipmentBuilder.Verify(x => x.GetShipments(shipments), Times.Once);
        }


        [Test]
        public void GetSalesOrder_Test06_InstantiateSalesInvoiceBuilder()
        {
            _salesOrderBuilder.GetSalesOrder(Guid.NewGuid());

            _mockedSalesOrderBuilder.Verify(x => x.InstantiateSalesInvoiceBuilder(), Times.Once);
        }


        [Test]
        public void GetSalesOrder_Test07_GetSalesInvoicesFromBuilder()
        {
            var salesInvoiceDts = new List<SalesInvoiceDt>();
            var shipments = new List<IShipment>();

            _mockedShipmentBuilder.Setup(x => x.GetShipments(It.IsAny<List<ShipmentDt>>())).Returns(shipments);
            _mockedSalesInvoiceRetriever.Setup(x => x.GetSalesInvoices(It.IsAny<Guid>())).Returns(salesInvoiceDts);

            _salesOrderBuilder.GetSalesOrder(Guid.NewGuid());

            _mockedSalesInvoiceBuilder.Verify(x => x.GetSalesInvoices(salesInvoiceDts, shipments), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test08_InstantiateSalesInvoiceBuilder()
        {
            var salesInvoices = new List<ISalesInvoice>();
            var salesOrderDt = new SalesOrderDt();

            _mockedSalesOrderRetriever.Setup(x => x.GetSalesOrderDt(It.IsAny<Guid>())).Returns(salesOrderDt);

            _mockedSalesInvoiceBuilder.Setup(
                x => x.GetSalesInvoices(It.IsAny<List<SalesInvoiceDt>>(), It.IsAny<List<IShipment>>()))
                .Returns(salesInvoices);

            _salesOrderBuilder.GetSalesOrder(Guid.NewGuid());

            _mockedSalesOrderBuilder.Verify(x => x.InstantiateSalesOrder(salesOrderDt, salesInvoices), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test09_ReturnSalesOrder()
        {
            var expected = new Mock<ISalesOrder>().Object;

            _mockedSalesOrderBuilder.Setup(
                x => x.InstantiateSalesOrder(It.IsAny<SalesOrderDt>(), It.IsAny<List<ISalesInvoice>>()))
                .Returns(expected);

            var actual = _salesOrderBuilder.GetSalesOrder(Guid.NewGuid());

            Assert.That(expected == actual);
        }
    }
}
