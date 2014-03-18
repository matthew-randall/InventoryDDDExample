using System;
using System.Net.Mime;
using Ninject;

namespace Inventory.DependencyInjector
{
    public class NinjectDependencyInjector
    {
        private IKernel _kernel;

        public void Initialize(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void InjectPropertiesOn(object obj)
        {
            if (_kernel == null)
                throw new NinjectDependencyInjectorHasNotBeenInitialized();

            _kernel.Inject(obj);
        }
        
        private static NinjectDependencyInjector _instance;
        public static NinjectDependencyInjector Instance
        {
            get { return _instance ?? (_instance = new NinjectDependencyInjector()); }
        }
    }

    public class NinjectDependencyInjectorHasNotBeenInitialized : ApplicationException { }
}
