using System;
using Moq;
using NUnit.Framework;
using Inventory.Application.Companies.Contracts.Interface.Sales;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Domain.Creation.Interface;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Application.Sales.Transactions;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.Application.Sales.Test.Unit.Transactions
{
    [TestFixture]
    public class SalesTransactionsTests
    {
        private Mock<SalesTransactions> _mockedSalesTransaction;
        private Mock<ISalesOrderBuilder> _mockedSalesOrderBuilder;
        private Mock<ICustomerBuilder> _mockedCustomerBuilder;

        private SalesTransactions _salesTransactions;
        private Mock<ICustomer> _mockedCustomer;
        private Mock<ICustomerRetriever> _mockedCustomerRetriever;
        private Mock<ICompanySalesTransactions> _mockedCompanyRetriever;
        private Mock<ISalesOrderPersistor> _mockedSalesOrderPersistor;
        private Mock<ISalesOrder> _mockedSalesOrder;

        [SetUp]
        public void SetUp()
        {
            _mockedCustomerRetriever = new Mock<ICustomerRetriever>();
            _mockedCompanyRetriever = new Mock<ICompanySalesTransactions>();
            _mockedSalesOrderPersistor = new Mock<ISalesOrderPersistor>();

            _mockedSalesOrderBuilder = new Mock<ISalesOrderBuilder>();
            _mockedCustomerBuilder = new Mock<ICustomerBuilder>();
            _mockedCustomer = new Mock<ICustomer>();
            _mockedSalesOrder = new Mock<ISalesOrder>();

            _mockedCustomerBuilder.Setup(x => x.GetCustomer(It.IsAny<string>())).Returns(_mockedCustomer.Object);
            _mockedSalesOrderBuilder.Setup(x => x.GetSalesOrder(It.IsAny<Guid>())).Returns(_mockedSalesOrder.Object);

            _mockedSalesTransaction = new Mock<SalesTransactions>();

            _mockedSalesTransaction.Setup(
                x => x.InstantiateCustomerBuilder())
                .Returns(_mockedCustomerBuilder.Object);

            _mockedSalesTransaction.Setup(x => x.InstantiateSalesOrderBuilder()).Returns(_mockedSalesOrderBuilder.Object);

            _salesTransactions = _mockedSalesTransaction.Object;
        }

        [Test]
        public void AddNewSalesOrder_Test01_GetCustomerBuilder()
        {
            _salesTransactions.AddNewSalesOrder("CUST01");

            _mockedSalesTransaction.Verify(
                x => x.InstantiateCustomerBuilder(),
                Times.Once);
        }

        [Test]
        public void AddNewSalesOrder_Test02_GetCustomer()
        {
            _salesTransactions.AddNewSalesOrder("CUST01");

            _mockedCustomerBuilder.Verify(x => x.GetCustomer("CUST01"), Times.Once);
        }

        [Test]
        public void AddNewSalesOrder_Test03_GetSalesOrderBuilder()
        {
            _salesTransactions.AddNewSalesOrder("CUST01");

            _mockedSalesTransaction.Verify(x => x.InstantiateSalesOrderBuilder(), Times.Once());
        }

        [Test]
        public void AddNewSalesOrder_Test04_CreateSalesOrder()
        {
            _salesTransactions.AddNewSalesOrder("CUST01");

            _mockedSalesOrderBuilder.Verify(x => x.CreateSalesOrder(_mockedCustomer.Object), Times.Once);
        }

        [Test]
        public void AddNewSalesOrder_Test05_ReturnSalesOrderId()
        {
            var guid = Guid.NewGuid();
            _mockedSalesOrderBuilder.Setup(x => x.CreateSalesOrder(_mockedCustomer.Object)).Returns(guid);
            
            var salesOrderId = _salesTransactions.AddNewSalesOrder("CUST01");

            Assert.That(salesOrderId, Is.EqualTo(guid));
        }

        [Test]
        public void GetSalesOrder_Test01_InstantiateSalesOrderBuilder()
        {
            _salesTransactions.GetSalesOrder(Guid.NewGuid());

            _mockedSalesTransaction.Verify(x => x.InstantiateSalesOrderBuilder(), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test02_GetSalesOrder()
        {
            var guid = Guid.NewGuid();
            _salesTransactions.GetSalesOrder(guid);

            _mockedSalesOrderBuilder.Verify(x => x.GetSalesOrder(guid), Times.Once);
        }

        [Test]
        public void GetSalesOrder_Test03_ReturnViewModel()
        {
            var expected = new SalesOrderVm();
            _mockedSalesOrder.Setup(x => x.GetSalesOrderVm()).Returns(expected);

            var actual = _salesTransactions.GetSalesOrder(Guid.NewGuid());

            Assert.That(actual == expected);
        }
    }
}
