using System;
using System.Windows.Controls;
using Ninject;
using Inventory.Application.Sales.Contracts.Interfaces.Transactions;
using Inventory.Application.Sales.Contracts.Models;
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
        public ISalesCommands SalesCommands { get; set; }

        private void LoadPageModel(Guid salesOrderId)
        {
            _salesOrder = SalesCommands.GetSalesOrder(salesOrderId);
        }
    }
}
