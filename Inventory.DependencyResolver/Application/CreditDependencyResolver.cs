using Ninject;
using Inventory.Application.Credits.Contracts.Interface.Transactions;
using Inventory.Application.Credits.Transactions;
using Inventory.DependencyResolver.Interface;

namespace Inventory.DependencyResolver.Application
{
    public class CreditDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public CreditDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Resolve()
        {
            _kernel.Bind<ICreditTransactions>().To<CreditTransactions>();
        }
    }
}
