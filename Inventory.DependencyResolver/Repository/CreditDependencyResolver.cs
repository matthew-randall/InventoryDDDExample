using Inventory.Repository.Fake;
using Inventory.Repository.Sales.Contracts.Interface;
using Ninject;

namespace Inventory.DependencyResolver.Repository
{
    internal class CreditDependencyResolver
    {
        private readonly IKernel _kernel;

        public CreditDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Resolve()
        {
            _kernel.Bind<ICreditRetriever>().To<CreditsRepository>();
        }
        
    }
}
