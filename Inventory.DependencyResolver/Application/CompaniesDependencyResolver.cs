using Inventory.Application.Companies.Sales.Contracts;
using Ninject;
using Inventory.Application.Companies.Transactions;
using Inventory.DependencyResolver.Interface;

namespace Inventory.DependencyResolver.Application
{
    public class CompaniesDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public CompaniesDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Resolve()
        {
            _kernel.Bind<IGetSalesSettings>().To<CompanyTransactions>();
        }
    }
}
