using System;

namespace Inventory.UI.Sales.Contracts.Models
{
    public class SalesOrderVm
    {
        public decimal SubTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Margin { get; set; }
        public decimal Profit { get; set; }
        public decimal TotalVolume { get; set; }
        public decimal TotalWeight { get; set; }
        public string CustomerCode { get; set; }
        public bool PrintInvoice { get; set; }
        public bool PrintPackingSlip { get; set; }
        public Guid SalesOrderId { get; set; }
        public string OrderNumber { get; set; }
        public int OpenSalesInvoiceCount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public decimal DiscountRate { get; set; }
        public AddressVm DeliveryAddress { get; set; }
        public CurrencyVm Currency { get; set; }
        public CompanyFeaturesVm CompanyFeatures { get; set; }
        public SalesTaxVm SalesTax { get; set; }
    }
}
