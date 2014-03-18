using Inventory.Application.Companies.Contracts.Interface.Sales;
using Inventory.Application.Companies.Contracts.Model.Sales;

namespace Inventory.Application.Companies.Transactions
{
    public class CompanyTransactions : ICompanySalesTransactions
    {
        public CompanySettings GetCompanySettings()
        {
            return new CompanySettings();
        }
    }
}
