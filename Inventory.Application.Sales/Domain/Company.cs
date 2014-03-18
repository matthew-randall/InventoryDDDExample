using Inventory.Application.Companies.Contracts.Model.Sales;
using Inventory.Application.Sales.Domain.Interface;

namespace Inventory.Application.Sales.Domain
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
