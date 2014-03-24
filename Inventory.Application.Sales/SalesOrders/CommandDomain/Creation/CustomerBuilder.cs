using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.DependencyInjector;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;
using Inventory.Application.Companies.Contracts.Interface.Sales;
using Inventory.Application.Companies.Contracts.Model.Sales;
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
        public ICompanySalesTransactions CompanySalesTransactions { get; set; }

        [Inject]
        public ICustomerRetriever CustomerRetriever { get; set; }

        public ICustomer GetCustomer(string customerCode)
        {
            var companyDt = CompanySalesTransactions.GetCompanySettings();
            var customerDt = CustomerRetriever.GetCustomer(customerCode);

            var company = InstantiateCompany(companyDt);
            var customer = InstantiateCustomer(customerDt, company);

            return customer;
        }

        internal virtual ICompany InstantiateCompany(CompanySettings company)
        {
            return new Company(company);
        }

        internal virtual ICustomer InstantiateCustomer(CustomerDt customerDt, ICompany company)
        {
            return new Customer(customerDt, company);
        }
    }
}
