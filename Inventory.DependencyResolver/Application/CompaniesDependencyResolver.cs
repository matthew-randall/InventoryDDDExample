using Inventory.Application.Companies.Contracts.Interface.Sales;
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
            _kernel.Bind<ICompanySalesTransactions>().To<CompanyTransactions>();
        }
    }
}
