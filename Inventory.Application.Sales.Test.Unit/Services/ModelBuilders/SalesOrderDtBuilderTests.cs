using System;
using Moq;
using NUnit.Framework;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Application.Sales.Services.ModelBuilders;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Test.Unit.Services.ModelBuilders
{
    [TestFixture]
    public class SalesOrderDtModelBuilderTests
    {
        [Test]
        public void Create_Test01_InstantiateObject()
        {
            var builder = new SalesOrderDtModelBuilder();
            var mockedCustomer = new Mock<ICustomer>();
            
            var dt = builder.Create(mockedCustomer.Object);

            Assert.That(dt, Is.InstanceOf<SalesOrderDt>());
        }

        [Test]
        public void Create_Test02_MapDefaultDetailsToSalesOrder()
        {
            var builder = new SalesOrderDtModelBuilder();
            var mockedCustomer = new Mock<ICustomer>();

            var dt = builder.Create(mockedCustomer.Object);

            Assert.That(dt.Id, Is.Not.Null);
            Assert.That(dt.Id, Is.Not.EqualTo(new Guid()));

            Assert.That(dt.OrderDate.Date, Is.EqualTo(DateTime.UtcNow.Date));
            Assert.That(dt.RequiredDate.Date, Is.EqualTo(DateTime.UtcNow.Date));
            Assert.That(dt.SalesOrderStatus == SalesOrderStatus.Parked);
        }

        [Test]
        public void Create_Test03_MapCustomerDetailsToSalesOrder()
        {
            var customerid = Guid.NewGuid();
            var warehouse = new WarehouseDt();
            var currency = new CurrencyDt();
            
            var mockedCustomer = new Mock<ICustomer>();
            mockedCustomer.Setup(x => x.CustomerId).Returns(customerid);
            mockedCustomer.Setup(x => x.Warehouse).Returns(warehouse);
            mockedCustomer.Setup(x => x.Currency).Returns(currency);
            
            var dt = new SalesOrderDtModelBuilder().Create(mockedCustomer.Object);

            Assert.That(dt.CustomerId == customerid);
            Assert.That(dt.Warehouse == warehouse);
            Assert.That(dt.Currency == currency);
        }
    }
}
