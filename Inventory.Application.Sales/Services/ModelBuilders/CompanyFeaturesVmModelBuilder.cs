using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.CommandDomain.Interface;
using Inventory.Application.Sales.Services.ModelBuilders.Interface;

namespace Inventory.Application.Sales.Services.ModelBuilders
{
    internal class CompanyFeaturesVmModelBuilder : ICompanyFeatureVmModelBuilder
    {
        public CompanyFeaturesVm Build(ICompany company)
        {
            throw new System.NotImplementedException();
        }
    }
}
