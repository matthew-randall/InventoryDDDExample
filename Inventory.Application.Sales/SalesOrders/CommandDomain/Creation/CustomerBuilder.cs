using Inventory.Application.Companies.Sales.Contracts;
using Inventory.Application.Companies.Sales.Contracts.Model;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.DependencyInjector;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;
using Ninject;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Creation
{
    internal class CustomerBuilder : ICustomerBuilder
    {

        public CustomerBuilder()
        {
            NinjectDependencyInjector.Instance.InjectPropertiesOn(this);
        }

        [Inject]
        public IGetSalesSettings CompanySalesTransactions { get; set; }

        [Inject]
        public ICustomerRetriever CustomerRetriever { get; set; }

        public ICustomer GetCustomer(string customerCode)
        {
            var companyDt = CompanySalesTransactions.Get();
            var customerDt = CustomerRetriever.GetCustomer(customerCode);

            var company = InstantiateCompany(companyDt);
            var customer = InstantiateCustomer(customerDt, company);

            return customer;
        }

        internal virtual ICompany InstantiateCompany(SalesSettings company)
        {
            return new Company(company);
        }

        internal virtual ICustomer InstantiateCustomer(CustomerDt customerDt, ICompany company)
        {
            return new Customer(customerDt, company);
        }
    }
}
