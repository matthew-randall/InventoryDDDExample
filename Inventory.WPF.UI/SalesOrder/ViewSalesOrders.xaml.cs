using System.Windows.Controls;

namespace Inventory.WPF.UI.SalesOrder
{
    /// <summary>
    /// Interaction logic for ViewSalesOrders.xaml
    /// </summary>
    public partial class ViewSalesOrders : Page
    {
        private ViewSalesOrders()
        {
            InitializeComponent();
        }
        
        private static ViewSalesOrders _instance;
        public static ViewSalesOrders Instance
        {
            get
            {
                return _instance ?? (_instance = new ViewSalesOrders());
            }
        }
    }
}
