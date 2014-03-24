using Inventory.Application.Companies.Sales.Contracts;
using Inventory.Application.Companies.Sales.Contracts.Model;

namespace Inventory.Application.Companies.Transactions
{
    public class CompanyTransactions : IGetSalesSettings
    {
        public SalesSettings Get()
        {
            return new SalesSettings();
        }
    }
}
