using Inventory.Application.Companies.Contracts.Model.Sales;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain
{
    internal class Company : ICompany
    {
        private readonly CompanySettings _company;

        public Company(CompanySettings company)
        {
            _company = company;
        }
    }
}
