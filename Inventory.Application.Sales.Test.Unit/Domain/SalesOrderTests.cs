using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Domain;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Application.Sales.Services.Builders.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Test.Unit.Domain
{
    [TestFixture]
    public class SalesOrderTests
    {
        private Mock<SalesOrder> _mockedSalesOrder;
        private SalesOrder _salesOrder;
        private Mock<ISalesOrderVmBuilder> _mockedSalesOrderVmBuilder;
        private SalesOrderDt _salesOrderDt;

        [SetUp]
        public void SetUp()
        {
            _salesOrderDt = new SalesOrderDt();

            _mockedSalesOrderVmBuilder = new Mock<ISalesOrderVmBuilder>();

            _mockedSalesOrder = new Mock<SalesOrder>(_salesOrderDt, new List<ISalesInvoice>());
            _mockedSalesOrder.Setup(x => x.InstantiateSalesOrderVmModelBuilder())
                .Returns(_mockedSalesOrderVmBuilder.Object);

            _salesOrder = _mockedSalesOrder.Object;
        }

        [Test]
        public void GetSalesOrderVm_Test01_InstantiateModelBuilder()
        {
            _salesOrder.GetSalesOrderVm();

            _mockedSalesOrder.Verify(x => x.InstantiateSalesOrderVmModelBuilder(), Times.Once);
        }

        [Test]
        public void GetSalesOrderVm_Test02_ExecuteModelBuilder()
        {
            _salesOrder.GetSalesOrderVm();

            _mockedSalesOrderVmBuilder.Verify(x => x.Build(_salesOrder), Times.Once);
        }

        [Test]
        public void GetSalesOrderVm_Test03_ReturnSalesOrderVm()
        {
            var expected = new SalesOrderVm();

            _mockedSalesOrderVmBuilder.Setup(x => x.Build(_salesOrder)).Returns(expected);

            var actual = _salesOrder.GetSalesOrderVm();

            Assert.That(expected == actual);

        }
    }
}
