using System;
using System.Windows.Controls;
using Inventory.UI.Sales.Contracts;
using Inventory.UI.Sales.Contracts.Models;
using Ninject;
using Inventory.DependencyInjector;

namespace Inventory.WPF.UI.SalesOrder
{
    /// <summary>
    /// Interaction logic for SalesOrderUpdate.xaml
    /// </summary>
    public partial class SalesOrderUpdate : Page
    {
        private SalesOrderVm _salesOrder;

        public SalesOrderUpdate(Guid salesOrderId)
        {
            InitializeComponent();
            NinjectDependencyInjector.Instance.InjectPropertiesOn(this);
            LoadPageModel(salesOrderId);
        }

        [Inject]
        public IGetSalesOrderVm GetSalesOrder { get; set; }

        private void LoadPageModel(Guid salesOrderId)
        {
            _salesOrder = GetSalesOrder.Get(salesOrderId);
        }
    }
}
