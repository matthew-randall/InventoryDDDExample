using System;
using System.Windows;
using System.Windows.Controls;
using Inventory.DependencyInjector;
using Inventory.UI.Sales.Contracts;
using Inventory.UI.Sales.Contracts.Credits.Queries;
using Inventory.WPF.UI.Credits.EventArguments;
using Ninject;

namespace Inventory.WPF.UI.Credits
{
    /// <summary>
    /// Interaction logic for ViewCredits.xaml
    /// </summary>
    public partial class ViewCredits : Page
    {
        private static ViewCredits _instance;
        public static ViewCredits Instance
        {
            get { return _instance ?? (_instance = new ViewCredits()); }
        }

        public ViewCredits()
        {
            NinjectDependencyInjector.Instance.InjectPropertiesOn(this);
            InitializeComponent();
        }

        [Inject]
        public IGetCreditViewList CreditQueries { get; set; }

        public void Reload()
        {
            tblCreditsView.ItemsSource = CreditQueries.Get(10);
        }

        private void BtnNavigateToCredit_OnClick(object sender, RoutedEventArgs e)
        {
            var creditView = ((FrameworkElement) sender).DataContext as CreditViewQuery;
            OnSelectedCredit.Invoke(this, new OnSelectedCreditEventArgs(creditView.CreditId));
        }

        public event EventHandler<OnSelectedCreditEventArgs> OnSelectedCredit;
    }
}
