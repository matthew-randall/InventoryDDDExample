using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Companies.Contracts.Interface
{
    public interface ICompanyRetriever
    {
        CompanyDt GetCurrentCompany();
    }
}
