using System.Windows;
using Inventory.DependencyInjector;
using Inventory.DependencyResolver;

namespace Inventory.WPF.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var kernel = NinjectDependencyResolver.ResolveAll();
            NinjectDependencyInjector.Instance.Initialize(kernel);
            base.OnStartup(e);
        }
    }
}
