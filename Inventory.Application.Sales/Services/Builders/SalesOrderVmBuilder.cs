using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Application.Sales.Services.Builders.Interface;
using Inventory.Application.Sales.Services.ModelBuilders;
using Inventory.Application.Sales.Services.ModelBuilders.Interface;

namespace Inventory.Application.Sales.Services.Builders
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
