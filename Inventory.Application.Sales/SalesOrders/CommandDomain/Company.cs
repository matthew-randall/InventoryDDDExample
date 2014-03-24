using Inventory.Application.Companies.Sales.Contracts.Model;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain
{
    internal class Company : ICompany
    {
        private readonly SalesSettings _company;

        public Company(SalesSettings company)
        {
            _company = company;
        }
    }
}
