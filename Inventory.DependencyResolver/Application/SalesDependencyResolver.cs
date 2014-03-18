using Ninject;
using Inventory.Application.Sales.Contracts.Interfaces.Transactions;
using Inventory.Application.Sales.Transactions;
using Inventory.DependencyResolver.Interface;

namespace Inventory.DependencyResolver.Application
{
    public class SalesDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public SalesDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Resolve()
        {
            _kernel.Bind<ISalesTransactions>().To<SalesTransactions>();
        }
    }
}
