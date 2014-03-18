using Ninject;
using Inventory.DependencyResolver.Application;

namespace Inventory.DependencyResolver
{
    public static class NinjectDependencyResolver
    {
        public static IKernel ResolveAll()
        {
            var kernel = new StandardKernel();

            new Repository.SalesDependencyResolver(kernel).Resolve();
            new SalesDependencyResolver(kernel).Resolve();
            new CreditDependencyResolver(kernel).Resolve();
            new CompaniesDependencyResolver(kernel).Resolve();

            return kernel;
        }
    }
}
