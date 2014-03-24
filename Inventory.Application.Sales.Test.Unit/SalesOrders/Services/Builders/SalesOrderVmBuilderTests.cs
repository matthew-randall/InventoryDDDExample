using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Application.Sales.SalesOrders.Services.Builders;
using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.SalesOrders.Services.Builders
{
    [TestFixture]
    public class SalesOrderVmBuilderTests
    {
        private Mock<SalesOrderVmBuilder> _mockedSalesOrderVmBuilder;
        private Mock<ISalesOrderVmModelBuilder> _mockedSalesOrderVmModelBuilder;
        private SalesOrderVmBuilder _salesOrderVmBuilder;
        private Mock<ISalesOrder> _mockedSalesOrder;
        private Mock<IAddressVmModelBuilder> _mockedAddressVmModelBuilder;
        private Mock<ICurrencyVmModelBuilder> _mockedCurrencyVmModelBuilder;
        private Mock<ICompanyFeatureVmModelBuilder> _mockedCompanyFeatureVmModelBuilder;
        private Mock<ICompany> _mockedCompany;
        private Mock<ICustomer> _mockedCustomer;
        private Mock<ISalesTaxVmModelBuilder> _mockedSalesTaxVmModelBuilder;

        [SetUp]
        public void SetUp()
        {
            _mockedSalesOrder = new Mock<ISalesOrder>();
            _mockedCompany = new Mock<ICompany>();
            _mockedCustomer = new Mock<ICustomer>();

            _mockedSalesOrder.Setup(x => x.Customer).Returns(_mockedCustomer.Object);
            _mockedCustomer.Setup(x => x.Company).Returns(_mockedCompany.Object);

            _mockedSalesOrder.Setup(x => x.DeliveryAddress).Returns(new AddressDt());
            _mockedSalesOrder.Setup(x => x.Currency).Returns(new CurrencyDt());
            _mockedSalesOrder.Setup(x => x.SalesTax).Returns(new SalesTaxDt());

            _mockedSalesOrderVmModelBuilder = new Mock<ISalesOrderVmModelBuilder>();
            _mockedAddressVmModelBuilder = new Mock<IAddressVmModelBuilder>();
            _mockedCurrencyVmModelBuilder = new Mock<ICurrencyVmModelBuilder>();
            _mockedCompanyFeatureVmModelBuilder = new Mock<ICompanyFeatureVmModelBuilder>();
            _mockedSalesTaxVmModelBuilder = new Mock<ISalesTaxVmModelBuilder>();
            
            _mockedSalesOrderVmModelBuilder.Setup(x => x.Build(_mockedSalesOrder.Object)).Returns(new SalesOrderVm());

            _mockedSalesOrderVmBuilder = new Mock<SalesOrderVmBuilder>();

            _mockedSalesOrderVmBuilder.Setup(x => x.InstantiateSalesOrderVmModelBuilder())
                .Returns(_mockedSalesOrderVmModelBuilder.Object);

            _mockedSalesOrderVmBuilder.Setup(x => x.InstantiateAddressVmModelBuilder())
                .Returns(_mockedAddressVmModelBuilder.Object);

            _mockedSalesOrderVmBuilder.Setup(x => x.InstantiateCurrencyVmModelBuilder())
                .Returns(_mockedCurrencyVmModelBuilder.Object);

            _mockedSalesOrderVmBuilder.Setup(x => x.InstantiateCompanyFeatureVmModelBuilder())
                .Returns(_mockedCompanyFeatureVmModelBuilder.Object);

            _mockedSalesOrderVmBuilder.Setup(x => x.InstantiateSalesTaxVmModelBuilder())
                .Returns(_mockedSalesTaxVmModelBuilder.Object);
            
            _salesOrderVmBuilder = _mockedSalesOrderVmBuilder.Object;
        }

        [Test]
        public void Build_Test01_InstantiateSalesOrderVmModelBuilder()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedSalesOrderVmBuilder.Verify(x => x.InstantiateSalesOrderVmModelBuilder(), Times.Once);
        }

        [Test]
        public void Build_Test02_BuildSalesOrderVmModel()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedSalesOrderVmModelBuilder.Verify(x => x.Build(_mockedSalesOrder.Object), Times.Once);
        }

        [Test]
        public void Build_Test03_InstantiateAddressVmModelBuilder()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);
            
            _mockedSalesOrderVmBuilder.Verify(x => x.InstantiateAddressVmModelBuilder(), Times.Once);
        }

        [Test]
        public void Build_Test04_BuidDeliveryAddressVm()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedAddressVmModelBuilder.Verify(x => x.Build(_mockedSalesOrder.Object.DeliveryAddress), Times.Once);
        }

        [Test]
        public void Build_Test05_InstantiateCurrencyVmModelBuilder()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedSalesOrderVmBuilder.Verify(x => x.InstantiateCurrencyVmModelBuilder(), Times.Once);
        }

        [Test]
        public void Build_Test06_BuidCurrencyVm()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedCurrencyVmModelBuilder.Verify(x => x.Build(_mockedSalesOrder.Object.Currency), Times.Once);
        }

        [Test]
        public void Build_Test07_InstantiateCompanyFeatureVmModelBuilder()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedSalesOrderVmBuilder.Verify(x => x.InstantiateCompanyFeatureVmModelBuilder(), Times.Once);
        }

        [Test]
        public void Build_Test08_BuidCompanyFeatureVm()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedCompanyFeatureVmModelBuilder.Verify(x => x.Build(_mockedSalesOrder.Object.Customer.Company), Times.Once);
        }

        [Test]
        public void Build_Test09_InstantiateSalesTaxVmModelBuilder()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedSalesOrderVmBuilder.Verify(x => x.InstantiateSalesTaxVmModelBuilder(), Times.Once);
        }

        [Test]
        public void Build_Test10_BuidCompanyFeatureVm()
        {
            _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            _mockedSalesTaxVmModelBuilder.Verify(x => x.Build(_mockedSalesOrder.Object.SalesTax), Times.Once);
        }

        [Test]
        public void Build_Test11_ReturnBuildSalesOrderVm()
        {
            var salesOrderVm = new SalesOrderVm();
            var addressVm = new AddressVm();
            var currencyVm = new CurrencyVm();
            var companyFeatures = new CompanyFeaturesVm();
            var salesTax = new SalesTaxVm();

            _mockedSalesOrderVmModelBuilder.Setup(x => x.Build(_mockedSalesOrder.Object)).Returns(salesOrderVm);
            _mockedAddressVmModelBuilder.Setup(x => x.Build(_mockedSalesOrder.Object.DeliveryAddress)).Returns(addressVm);
            _mockedCurrencyVmModelBuilder.Setup(x => x.Build(_mockedSalesOrder.Object.Currency)).Returns(currencyVm);
            _mockedCompanyFeatureVmModelBuilder.Setup(x => x.Build(_mockedSalesOrder.Object.Customer.Company)).Returns(companyFeatures);
            _mockedSalesTaxVmModelBuilder.Setup(x => x.Build(_mockedSalesOrder.Object.SalesTax)).Returns(salesTax);

            var vm = _salesOrderVmBuilder.Build(_mockedSalesOrder.Object);

            Assert.That(vm, Is.EqualTo(salesOrderVm));
            Assert.That(vm.DeliveryAddress, Is.EqualTo(addressVm));
            Assert.That(vm.Currency, Is.EqualTo(currencyVm));
            Assert.That(vm.CompanyFeatures, Is.EqualTo(companyFeatures));
            Assert.That(vm.SalesTax, Is.EqualTo(salesTax));
        }
    }
}
