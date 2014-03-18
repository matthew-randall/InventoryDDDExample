using Ninject;
using Inventory.DependencyResolver.Interface;
using Inventory.Repository.Fake;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.DependencyResolver.Repository
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
            _kernel.Bind<ICustomerRetriever>().To<CustomerRepository>();
            _kernel.Bind<ISalesOrderPersistor>().To<SalesOrderRepository>();
            _kernel.Bind<ISalesOrderRetriever>().To<SalesOrderRepository>();
            _kernel.Bind<ISalesInvoiceRetriever>().To<SalesInvoiceRepository>();
            _kernel.Bind<IShipmentRetriever>().To<ShipmentRepository>();
        }
    }
}
