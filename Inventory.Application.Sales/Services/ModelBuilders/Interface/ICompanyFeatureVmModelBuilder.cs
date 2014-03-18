using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Domain.Interface;

namespace Inventory.Application.Sales.Services.ModelBuilders.Interface
{
    internal interface ICompanyFeatureVmModelBuilder
    {
        CompanyFeaturesVm Build(ICompany company);
    }
}
