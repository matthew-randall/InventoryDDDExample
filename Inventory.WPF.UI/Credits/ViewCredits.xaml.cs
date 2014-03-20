using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using Inventory.Application.Credits.Contracts.Interface;
using Inventory.Application.Credits.Contracts.Queries;
using Inventory.DependencyInjector;
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
        public ICreditQueries CreditQueries { get; set; }

        public void Reload()
        {
            tblCreditsView.ItemsSource = CreditQueries.GetCreditViewList(10);
        }
    }
}
