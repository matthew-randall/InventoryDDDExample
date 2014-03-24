using Inventory.Application.Sales.Credits;
using Inventory.UI.Sales.Contracts;
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
            _kernel.Bind<IGetCreditView>().To<CreditCommands>();
            _kernel.Bind<IGetCreditViewList>().To<CreditQueries>();
        }
    }
}
