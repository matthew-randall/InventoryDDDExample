using System.Windows;
using Ninject;
using Inventory.Application.Sales.Contracts.Interfaces.Transactions;
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
        }

        [Inject]
        public ISalesCommands SalesCommands { get; set; }

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
            var salesOrderId = SalesCommands.AddNewSalesOrder(customerCode);
            PageFrame.Navigate(new SalesOrderUpdate(salesOrderId));
        }
    }
}
