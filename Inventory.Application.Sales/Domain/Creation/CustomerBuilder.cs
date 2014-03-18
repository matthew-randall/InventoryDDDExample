using Ninject;
using Inventory.Application.Companies.Contracts.Interface.Sales;
using Inventory.Application.Companies.Contracts.Model.Sales;
using Inventory.Application.Sales.Domain.Creation.Interface;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.DependencyInjector;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.Application.Sales.Domain.Creation
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
