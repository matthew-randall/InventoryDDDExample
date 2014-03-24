using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using Inventory.DependencyInjector;
using Inventory.UI.Sales.Contracts.Credits.Interface;
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
        public ICreditCommands CreditCommands { get; set; }
        
        public void SetCredit(Guid creditId)
        {
            var pageModel = CreditCommands.GetCreditView(creditId);
            this.DataContext = pageModel;
        }
    }
}
