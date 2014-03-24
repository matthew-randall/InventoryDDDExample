using Inventory.Application.Sales.SalesOrders;
using Inventory.UI.Sales.Contracts;
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
            _kernel.Bind<IGetSalesOrderVm>().To<SalesCommands>();
        }
    }
}
