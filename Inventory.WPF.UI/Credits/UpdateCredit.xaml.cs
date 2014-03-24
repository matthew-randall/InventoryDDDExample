using System;
using System.Windows.Controls;
using Inventory.DependencyInjector;
using Inventory.UI.Sales.Contracts;
using Ninject;

namespace Inventory.WPF.UI.Credits
{
    /// <summary>
    /// Interaction logic for UpdateCredit.xaml
    /// </summary>
    public partial class UpdateCredit : Page
    {
        private static UpdateCredit _instance;
        public static UpdateCredit Instance
        {
            get { return _instance ?? (_instance = new UpdateCredit()); }
        }

        public UpdateCredit()
        {
            NinjectDependencyInjector.Instance.InjectPropertiesOn(this);
            InitializeComponent();
        }

        [Inject]
        public IGetCreditView GetCredit { get; set; }
        
        public void SetCredit(Guid creditId)
        {
            var pageModel = GetCredit.Get(creditId);
            this.DataContext = pageModel;
        }
    }
}
