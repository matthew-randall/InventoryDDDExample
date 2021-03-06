﻿using Inventory.Application.Companies.Sales.Contracts;
using Inventory.Application.Companies.Sales.Contracts.Model;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.DependencyInjector;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;
using Moq;
using Ninject;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.SalesOrders.CommandDomain.Creation
{
    [TestFixture]
    public class CustomerBuilderTests
    {
        private Mock<CustomerBuilder> _mockedCustomerBuilder;
        private Mock<ICompany> _mockedCompany;
        private Mock<ICustomer> _mockedCustomer;
        private Mock<IGetSalesSettings> _mockedCompanySalesTransactions;
        private Mock<ICustomerRetriever> _mockedCustomerRetriever;

        private CustomerBuilder _customerBuilder;
        private CustomerDt _customerDt;
        private SalesSettings _companySettings;

        [SetUp]
        public void SetUp()
        {
            _customerDt = new CustomerDt();
            _companySettings = new SalesSettings();

            _mockedCompany = new Mock<ICompany>();
            _mockedCustomer = new Mock<ICustomer>();

            _mockedCompanySalesTransactions = new Mock<IGetSalesSettings>();
            _mockedCustomerRetriever = new Mock<ICustomerRetriever>();

            _mockedCompanySalesTransactions.Setup(x => x.Get()).Returns(_companySettings);
            _mockedCustomerRetriever.Setup(x => x.GetCustomer(It.IsAny<string>())).Returns(_customerDt);
            
            _mockedCustomerBuilder = new Mock<CustomerBuilder>();

            _mockedCustomerBuilder.Setup(x => x.InstantiateCompany(_companySettings)).Returns(_mockedCompany.Object);
            _mockedCustomerBuilder.Setup(x => x.InstantiateCustomer(_customerDt, It.IsAny<ICompany>())).Returns(_mockedCustomer.Object);
            

            IKernel kernel = new StandardKernel();

            kernel.Bind<IGetSalesSettings>().ToConstant(_mockedCompanySalesTransactions.Object);
            kernel.Bind<ICustomerRetriever>().ToConstant(_mockedCustomerRetriever.Object);

            NinjectDependencyInjector.Instance.Initialize(kernel);

            _customerBuilder = _mockedCustomerBuilder.Object;
        }

        [Test]
        public void GetCustomer_Test01_GetCompanyFromRepository()
        {
            _customerBuilder.GetCustomer("CUST01");
            _mockedCustomerBuilder.Verify(x => x.InstantiateCompany(_companySettings), Times.Once);
        }

        [Test]
        public void GetCustomer_Test02_InstantiateCompany()
        {
            _customerBuilder.GetCustomer("CUST01");
            _mockedCustomerBuilder.Verify(x => x.InstantiateCompany(_companySettings), Times.Once);
        }
        
        [Test]
        public void GetCustomer_Test03_InstantiateCustomer()
        {
            _customerBuilder.GetCustomer("CUST01");
            _mockedCustomerBuilder.Verify(x => x.InstantiateCustomer(_customerDt, _mockedCompany.Object), Times.Once);
        }

        [Test]
        public void GetCustomer_Test04_ReturnCustomer()
        {
            var customer = _customerBuilder.GetCustomer("CUST01");
            Assert.That(customer, Is.EqualTo(_mockedCustomer.Object));
        }
    }
}
