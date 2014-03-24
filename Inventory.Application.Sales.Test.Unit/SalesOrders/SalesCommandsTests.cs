using System;
using Inventory.Application.Companies.Sales.Contracts;
using Inventory.Application.Sales.SalesOrders;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Repository.Sales.Contracts.Interface;
using Inventory.UI.Sales.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.SalesOrders
{
    [TestFixture]
    public class SalesCommandsTests
    {
        private Mock<SalesCommands> _mockedSalesTransaction;
        private Mock<ISalesOrderBuilder> _mockedSalesOrderBuilder;
        private Mock<ICustomerBuilder> _mockedCustomerBuilder;

        private SalesCommands _salesCommands;
        private Mock<ICustomer> _mockedCustomer;
        private Mock<ICustomerRetriever> _mockedCustomerRetriever;
        private Mock<IGetSalesSettings> _mockedCompanyRetriever;
        private Mock<ISalesOrderPersistor> _mockedSalesOrderPersistor;
        private Mock<ISalesOrder> _mockedSalesOrder;

        [SetUp]
        public void SetUp()
        {
            _mockedCustomerRetriever = new Mock<ICustomerRetriever>();
            _mockedCompanyRetriever = new Mock<IGetSalesSettings>();
            _mockedSalesOrderPersistor = new Mock<ISalesOrderPersistor>();

            _mockedSalesOrderBuilder = new Mock<ISalesOrderBuilder>();
            _mockedCustomerBuilder = new Mock<ICustomerBuilder>();
            _mockedCustomer = new Mock<ICustomer>();
            _mockedSalesOrder = new Mock<ISalesOrder>();

            _mockedCustomerBuilder.Setup(x => x.GetCustomer(It.IsAny<string>())).Returns(_mockedCustomer.Object);
            _mockedSalesOrderBuilder.Setup(x => x.GetSalesOrder(It.IsAny<Guid>())).Returns(_mockedSalesOrder.Object);

            _mockedSalesTransaction = new Mock<SalesCommands>();

            _mockedSalesTransaction.Setup(
                x => x.InstantiateCustomerBuilder())
                .Returns(_mockedCustomerBuilder.Object);

            _mockedSalesTransaction.Setup(x => x.InstantiateSalesOrderBuilder()).Returns(_mockedSalesOrderBuilder.Object);

            _salesCommands = _mockedSalesTransaction.Object;
        }

        [Test]
        public void AddNewSalesOrder_Test01_GetCustomerBuilder()
        {
            _salesCommands.Add("CUST01");

            _mockedSalesTransaction.Verify(
                x => x.InstantiateCustomerBuilder(),
                Times.Once);
        }

        [Test]
        public void AddNewSalesOrder_Test02_GetCustomer()
        {
            _salesCommands.Add("CUST01");

            _mockedCustomerBuilder.Verify(x => x.GetCustomer("CUST01"), Times.Once);
        }

        [Test]
        public void AddNewSalesOrder_Test03_GetSalesOrderBuilder()
        {
            _salesCommands.Add("CUST01");

            _mockedSalesTransaction.Verify(x => x.InstantiateSalesOrderBuilder(), Times.Once());
        }

        [Test]
        public void AddNewSalesOrder_Test04_CreateSalesOrder()
        {
            _salesCommands.Add("CUST01");

            _mockedSalesOrderBuilder.Verify(x => x.CreateSalesOrder(_mockedCustomer.Object), Times.Once);
        }

        [Test]
        public void AddNewSalesOrder_Test05_ReturnSalesOrderId()
        {
            var guid = Guid.NewGuid();
            _mockedSalesOrderBuilder.Setup(x => x.CreateSalesOrder(_mockedCustomer.Object)).Returns(guid);
            
            var salesOrderId = _salesCommands.Add("CUST01");

            Assert.That(salesOrderId, Is.EqualTo(guid));
        }

        [Test]
        public void GetSalesOrder_Test01_InstantiateSalesOrderBuilder()
        {
            _salesCommands.Get(Guid.NewGuid());

            _mockedSalesTransaction.Verify(x => x.InstantiateSalesOrderBuilder(), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test02_GetSalesOrder()
        {
            var guid = Guid.NewGuid();
            _salesCommands.Get(guid);

            _mockedSalesOrderBuilder.Verify(x => x.GetSalesOrder(guid), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test03_ReturnViewModel()
        {
            var expected = new SalesOrderVm();
            _mockedSalesOrder.Setup(x => x.GetSalesOrderVm()).Returns(expected);

            var actual = _salesCommands.Get(Guid.NewGuid());

            Assert.That(actual == expected);
        }
    }
}
