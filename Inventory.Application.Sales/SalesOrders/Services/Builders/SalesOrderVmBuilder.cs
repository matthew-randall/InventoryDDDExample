using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Application.Sales.SalesOrders.Services.Builders.Interface;
using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders;
using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.Builders
{
    internal class SalesOrderVmBuilder : ISalesOrderVmBuilder
    {
        public SalesOrderVm Build(ISalesOrder salesOrder)
        {
            var salesOrderVm = InstantiateSalesOrderVmModelBuilder().Build(salesOrder);

            salesOrderVm.DeliveryAddress = InstantiateAddressVmModelBuilder().Build(salesOrder.DeliveryAddress);
            salesOrderVm.Currency = InstantiateCurrencyVmModelBuilder().Build(salesOrder.Currency);
            salesOrderVm.CompanyFeatures = InstantiateCompanyFeatureVmModelBuilder().Build(salesOrder.Customer.Company);
            salesOrderVm.SalesTax = InstantiateSalesTaxVmModelBuilder().Build(salesOrder.SalesTax);

            return salesOrderVm;
        }

        internal virtual ISalesOrderVmModelBuilder InstantiateSalesOrderVmModelBuilder()
        {
            return new SalesOrderVmModelBuilder();
        }

        internal virtual IAddressVmModelBuilder InstantiateAddressVmModelBuilder()
        {
            return new AddressVmModelBuilder();
        }

        internal virtual ICurrencyVmModelBuilder InstantiateCurrencyVmModelBuilder()
        {
            return new CurrencyVmModelBuilder();
        }

        internal virtual ICompanyFeatureVmModelBuilder InstantiateCompanyFeatureVmModelBuilder()
        {
            return new CompanyFeaturesVmModelBuilder();
        }

        internal virtual ISalesTaxVmModelBuilder InstantiateSalesTaxVmModelBuilder()
        {
            return new SalesTaxVmModelBuilder();
        }
    }
}
