using System;
using System.Collections.Generic;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Domain.Interface;
using Inventory.Application.Sales.Services.Builders;
using Inventory.Application.Sales.Services.Builders.Interface;
using Inventory.Application.Sales.Services.ModelBuilders;
using Inventory.Application.Sales.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Domain
{
    internal class SalesOrder : ISalesOrder
    {
        private readonly SalesOrderDt _salesOrderDt;

        public SalesOrder(SalesOrderDt salesOrderDt, List<ISalesInvoice> salesInvoices)
        {
            _salesOrderDt = salesOrderDt;
            SalesInvoices = salesInvoices;
        }

        public Guid SalesOrderId { get; private set; }
        public string OrderNumber { get; private set; }
        public DateTime OrderDate { get; private set; }
        public DateTime RequiredDate { get; private set; }
        public AddressDt DeliveryAddress { get; private set; }
        public CurrencyDt Currency { get; private set; }
        public DeliveryMethodDt DeliveryMethod { get; private set; }
        public decimal Discount { get; private set; }
        public SalesTaxDt SalesTax { get; private set; }
        public List<ISalesOrderLine> SalesOrderLines { get; private set; }
        public ICustomer Customer { get; private set; }
        public List<ISalesInvoice> SalesInvoices { get; private set; }
        public decimal DiscountRate { get; set; }
        public decimal SubTotal { get; private set; }
        public decimal TaxTotal { get; private set; }
        public decimal Total { get; private set; }
        public decimal Margin { get; private set; }
        public decimal Profit { get; private set; }
        public decimal TotalVolume { get; private set; }
        public decimal TotalWeight { get; private set; }

        public SalesOrderVm GetSalesOrderVm()
        {
            var builder = InstantiateSalesOrderVmModelBuilder();
            var vm = builder.Build(this);
            return vm;
        }

        public List<ISalesInvoice> GetOpenInvoices()
        {
            throw new NotImplementedException();
        }

        internal virtual ISalesOrderVmBuilder InstantiateSalesOrderVmModelBuilder()
        {
            return new SalesOrderVmBuilder();
        }
    }
}
