using Inventory.Application.Credits;
using Inventory.Application.Credits.Contracts.Interface;
using Ninject;
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
            _kernel.Bind<ICreditCommands>().To<CreditCommands>();
            _kernel.Bind<ICreditQueries>().To<CreditQueries>();
        }
    }
}
