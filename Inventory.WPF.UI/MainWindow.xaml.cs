using System.Windows;
using Inventory.UI.Sales.Contracts;
using Inventory.WPF.UI.Credits;
using Inventory.WPF.UI.Credits.EventArguments;
using Ninject;
using Inventory.DependencyInjector;
using Inventory.WPF.UI.SalesOrder;

namespace Inventory.WPF.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NinjectDependencyInjector.Instance.InjectPropertiesOn(this);
            ViewCredits.Instance.OnSelectedCredit += OnSelectCredit;
        }

        [Inject]
        public IAddNewSalesOrder AddNewSales { get; set; }

        private void btnAddSalesOrder_Click(object sender, RoutedEventArgs e)
        {
            PopCreateSalesOrder.IsOpen = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";

            PopCreateSalesOrder.IsOpen = false;
        }

        private void btnViewSalesOrder_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Navigate(ViewSalesOrders.Instance);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var customerCode = txtCustomerCode.Text;
            var salesOrderId = AddNewSales.Add(customerCode);
            PageFrame.Navigate(new SalesOrderUpdate(salesOrderId));
        }

        private void btnViewCredits_Click(object sender, RoutedEventArgs e)
        {
            ViewCredits.Instance.Reload();
            PageFrame.Navigate(ViewCredits.Instance);
        }

        private void OnSelectCredit(object sender, OnSelectedCreditEventArgs e)
        {
            UpdateCredit.Instance.SetCredit(e.CreditId);
            PageFrame.Navigate(UpdateCredit.Instance);
        }
    }
}
