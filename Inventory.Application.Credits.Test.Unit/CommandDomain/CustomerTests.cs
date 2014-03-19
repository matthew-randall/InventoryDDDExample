using System;
using Inventory.Application.Credits.CommandDomain;
using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Credits.Tests.Unit.CommandDomain
{
    [TestFixture]
    public class CustomerTests
    {
        private CustomerDt _customerDt;
        private Customer _customer;
        private Mock<ICompany> _mockedCompany;

        [SetUp]
        public void SetUp()
        {
            _customerDt = new CustomerDt();
            _mockedCompany = new Mock<ICompany>();
            _customer = new Customer(_customerDt, _mockedCompany.Object);
        }

        [Test]
        public void Currency_Test01_CustomerCurrencyIsUsed()
        {
            _customerDt.Currency = new CurrencyDt();

            Assert.That(_customer.Currency == _customerDt.Currency);
        }

        [Test]
        public void Currency_Test02_CompanyCurrencyIsUsed()
        {
            var currency = new CurrencyDt();
            _mockedCompany.Setup(x => x.DefaultCurrency).Returns(currency);

            Assert.That(_customer.Currency == currency);
        }

        [Test]
        public void CustomerId_Test01()
        {
            _customerDt.CustomerId = Guid.NewGuid();

            Assert.That(_customer.CustomerId == _customerDt.CustomerId);
        }

        [Test]
        public void CustomerCode_Test01()
        {
            _customerDt.CustomerCode = "CODE";

            Assert.That(_customer.CustomerCode == _customerDt.CustomerCode);
        }

        [Test]
        public void CustomerName_Test01()
        {
            _customerDt.CustomerName = "NAME";

            Assert.That(_customer.CustomerName == _customerDt.CustomerName);
        }

        [Test]
        public void Email_Test01()
        {
            _customerDt.Email = "NAME@EMAIL";

            Assert.That(_customer.Email == _customerDt.Email);
        }

        [Test]
        public void Warehouse_Test01_UseCustomersWarehouse()
        {
            _customerDt.DefaultWarehouse = new WarehouseDt();

            Assert.That(_customer.Warehouse == _customerDt.DefaultWarehouse);
        }

        [Test]
        public void Warehouse_Test02_UseCompaniesWarehouse()
        {
            var warehouse = new WarehouseDt();
            _mockedCompany.Setup(x => x.DefaultWarehouse).Returns(warehouse);

            Assert.That(_customer.Warehouse == warehouse);
        }

        [Test]
        public void Company_Test01()
        {
            Assert.That(_customer.Company == _mockedCompany.Object);
        }

        [Test]
        public void Taxable_Test01()
        {
            _customerDt.Taxable = true;
            Assert.IsTrue(_customer.Taxable);
        }

        [Test]
        public void SalesTax_Test01()
        {

        }

        [Test]
        public void CreateFreeCredit_Test01()
        {

        }
    }
}
