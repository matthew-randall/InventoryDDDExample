using System;
using System.Collections.Generic;
using Inventory.Application.Sales.Contracts.Models;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.CommandDomain.Interface
{
    internal interface ISalesOrder
    {
        Guid SalesOrderId { get; }
        string OrderNumber { get; }
        DateTime OrderDate { get; }
        DateTime RequiredDate { get; }
        AddressDt DeliveryAddress { get; }
        CurrencyDt Currency { get; }
        decimal Discount { get; }
        SalesTaxDt SalesTax { get; }
        DeliveryMethodDt DeliveryMethod { get; }
        decimal SubTotal { get; }
        decimal TaxTotal { get; }
        decimal Total { get; }
        decimal Margin { get; }
        decimal Profit { get; }
        decimal TotalVolume { get; }
        decimal TotalWeight { get; }
        SalesOrderVm GetSalesOrderVm();
        ICustomer Customer { get; }
        List<ISalesOrderLine> SalesOrderLines { get; }
        List<ISalesInvoice> SalesInvoices { get; }
        decimal DiscountRate { get; set; }
        List<ISalesInvoice> GetOpenInvoices();
    }
}
