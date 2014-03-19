using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.CommandDomain.Interface;
using Inventory.Application.Sales.Services.ModelBuilders;

namespace Inventory.Application.Sales.Tests.Unit.Services.ModelBuilders
{
    [TestFixture]
    public class SalesOrderVmModelBuilderTests
    {
        private SalesOrderVmModelBuilder _salesOrderVmModelBuilder;
        private Mock<ISalesOrder> _mockedSalesOrder;
        private Mock<ICustomer> _mockedCustomer;

        [SetUp]
        public void SetUp()
        {
            _mockedSalesOrder = new Mock<ISalesOrder>();
            _mockedCustomer = new Mock<ICustomer>();

            _mockedSalesOrder.Setup(x => x.Customer).Returns(_mockedCustomer.Object);
            _mockedSalesOrder.Setup(x => x.GetOpenInvoices()).Returns(new List<ISalesInvoice>());

            _salesOrderVmModelBuilder = new SalesOrderVmModelBuilder();
        }

        [Test]
        [ExpectedException(typeof(SalesOrderVmModelBuilder.SalesOrderCannotBeNullException))]
        public void Buid_Test01_ThrowNullException()
        {
            _salesOrderVmModelBuilder.Build(null);
        }
        
        [Test]
        public void Build_Test02_ReturnVm()
        {
            var vm = _salesOrderVmModelBuilder.Build(_mockedSalesOrder.Object);

            Assert.That(vm, Is.InstanceOf<SalesOrderVm>());
        }

        [Test]
        public void Build_Test03_AssignTotals()
        {
            var subTotal = 123.5m;
            var taxTotal = 54.99m;
            var total = 12.54m;
            var margin = 43.23m;
            var profit = 66.6m;
            var totalVolume = 100.99m;
            var totalWeight = 123.66m;

            _mockedSalesOrder.Setup(x => x.SubTotal).Returns(subTotal);
            _mockedSalesOrder.Setup(x => x.TaxTotal).Returns(taxTotal);
            _mockedSalesOrder.Setup(x => x.Total).Returns(total);
            _mockedSalesOrder.Setup(x => x.Margin).Returns(margin);
            _mockedSalesOrder.Setup(x => x.Profit).Returns(profit);
            _mockedSalesOrder.Setup(x => x.TotalVolume).Returns(totalVolume);
            _mockedSalesOrder.Setup(x => x.TotalWeight).Returns(totalWeight);

            var viewModel = _salesOrderVmModelBuilder.Build(_mockedSalesOrder.Object);
            
            Assert.That(viewModel.SubTotal == subTotal);
            Assert.That(viewModel.TaxTotal == taxTotal);
            Assert.That(viewModel.Total == total);
            Assert.That(viewModel.Margin == margin);
            Assert.That(viewModel.Profit == profit);
            Assert.That(viewModel.TotalVolume == totalVolume);
            Assert.That(viewModel.TotalWeight == totalWeight);
        }

        [Test]
        public void Build_Test04_AssignCustomerDetails()
        {
            const string customerCode = "CUST01";
            const bool printInvoice = true;
            const bool printPackingSlip = true;

            _mockedCustomer.Setup(x => x.CustomerCode).Returns(customerCode);
            _mockedCustomer.Setup(x => x.PrintInvoice).Returns(printInvoice);
            _mockedCustomer.Setup(x => x.PrintPackingSlip).Returns(printPackingSlip);

            var viewModel = _salesOrderVmModelBuilder.Build(_mockedSalesOrder.Object);

            Assert.That(viewModel.CustomerCode == customerCode);
            Assert.That(viewModel.PrintInvoice == printInvoice);
            Assert.That(viewModel.PrintPackingSlip == printPackingSlip);
        }

        [Test]
        public void Build_Test05_AssignInvoiceDetails()
        {

            var openSalesInvoiceList = new List<ISalesInvoice>
            {
                new Mock<ISalesInvoice>().Object,
                new Mock<ISalesInvoice>().Object
            };

            _mockedSalesOrder.Setup(x => x.GetOpenInvoices()).Returns(openSalesInvoiceList);

            var viewModel = _salesOrderVmModelBuilder.Build(_mockedSalesOrder.Object);
            Assert.That(viewModel.OpenSalesInvoiceCount == 2);
        }

        [Test]
        public void Build_Test06_AssignOrderDetails()
        {
            var salesOrderId = Guid.NewGuid();
            const string orderNumber = "OrderNumber";
            var orderDate = DateTime.Now;
            var requiredDate = DateTime.UtcNow;
            const decimal discount = 12.54m;

            _mockedSalesOrder.Setup(x => x.SalesOrderId).Returns(salesOrderId);
            _mockedSalesOrder.Setup(x => x.OrderNumber).Returns(orderNumber);
            _mockedSalesOrder.Setup(x => x.OrderDate).Returns(orderDate);
            _mockedSalesOrder.Setup(x => x.RequiredDate).Returns(requiredDate);
            _mockedSalesOrder.Setup(x => x.DiscountRate).Returns(discount);

            var viewModel = _salesOrderVmModelBuilder.Build(_mockedSalesOrder.Object);

            Assert.That(viewModel.SalesOrderId == salesOrderId);
            Assert.That(viewModel.OrderNumber == orderNumber);
            Assert.That(viewModel.OrderDate == orderDate);
            Assert.That(viewModel.RequiredDate == requiredDate);
            Assert.That(viewModel.DiscountRate == discount);
        }
    }
}
