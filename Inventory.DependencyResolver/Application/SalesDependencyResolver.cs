using Inventory.Application.Sales;
using Inventory.Application.Sales.SalesOrders;
using Inventory.UI.Sales.Contracts.Interfaces.Transactions;
using Ninject;
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
            _kernel.Bind<ISalesCommands>().To<SalesCommands>();
        }
    }
}
