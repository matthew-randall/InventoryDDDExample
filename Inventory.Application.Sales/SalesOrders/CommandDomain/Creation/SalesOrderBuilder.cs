using System;
using System.Collections.Generic;
using System.Linq;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Creation.Interface;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders;
using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface;
using Inventory.DependencyInjector;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;
using Ninject;

namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Creation
{
    internal class SalesOrderBuilder : ISalesOrderBuilder
    {
        public SalesOrderBuilder()
        {
            NinjectDependencyInjector.Instance.InjectPropertiesOn(this);
        }

        [Inject]
        public ISalesOrderPersistor SalesOrderPersistor { get; set; }

        [Inject]
        public ISalesOrderRetriever SalesOrderRetriever { get; set; }

        [Inject]
        public ISalesInvoiceRetriever SalesInvoiceRetriever { get; set; }

        [Inject]
        public IShipmentRetriever ShipmentRetriever { get; set; }

        public Guid CreateSalesOrder(ICustomer customer)
        {
            var salesOrderDt = InstantiateSalesOrderDtBuilder().Create(customer);
            SalesOrderPersistor.AddSalesOrder(salesOrderDt);
            return salesOrderDt.Id;
        }

        public ISalesOrder GetSalesOrder(Guid salesOrderId)
        {
            var salesOrderDt = SalesOrderRetriever.GetSalesOrderDt(salesOrderId);
            var salesInvoicesDts = SalesInvoiceRetriever.GetSalesInvoices(salesOrderId);
            var shipmentsDts = ShipmentRetriever.GetShipmentsForInvoices(salesInvoicesDts.Select(x => x.SalesInvoiceId).ToArray());

            var shipments = InstantiateShipmentBuilder().GetShipments(shipmentsDts);
            var invoices = InstantiateSalesInvoiceBuilder().GetSalesInvoices(salesInvoicesDts, shipments);

            return InstantiateSalesOrder(salesOrderDt, invoices);
        }

        internal virtual ISalesOrderDtModelBuilder InstantiateSalesOrderDtBuilder()
        {
            return new SalesOrderDtModelBuilder();
        }
        
        internal virtual IShipmentBuilder InstantiateShipmentBuilder()
        {
            return new ShipmentBuilder();
        }

        internal virtual ISalesInvoiceBuilder InstantiateSalesInvoiceBuilder()
        {
            return new SalesInvoiceBuilder();
        }

        internal virtual ISalesOrder InstantiateSalesOrder(SalesOrderDt salesOrderDt, List<ISalesInvoice> salesInvoices)
        {
            return new SalesOrder(salesOrderDt, salesInvoices);
        }
    }
}
