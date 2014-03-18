using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Companies.Contracts.Interface;

namespace Inventory.Repository.Fake
{
    public class CompanyRepository : ICompanyRetriever
    {
        public CompanyDt GetCurrentCompany()
        {
            return new CompanyDt();
        }
    }
}
