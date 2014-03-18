using System;
using System.Collections.Generic;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class CustomerDt
    {
        public string BankAccount { get; set; }

        public string BankBranch { get; set; }

        public string BankName { get; set; }

        public CurrencyDt Currency { get; set; }

        public string CustomerCode { get; set; }

        public string CustomerName { get; set; }

        public Enum.CustomerType CustomerType { get; set; }

        public string DDINumber { get; set; }

        public string DefaultInvoiceEmail { get; set; }

        public string DefaultPackingSlipEmail { get; set; }

        public PaymentTermDt DefaultPaymentTerm { get; set; }

        public WarehouseDt DefaultWarehouse { get; set; }

        public decimal DiscountRate { get; set; }

        public string Email { get; set; }

        public string EmailCC { get; set; }

        public string FaxNumber { get; set; }

        public string GSTVATNumber { get; set; }

        public int InvoiceLayoutId { get; set; }

        public int PackingSlipLayoutId { get; set; }

        public string MobileNumber { get; set; }

        public string Notes { get; set; }

        public bool Obsolete { get; set; }

        public string PhoneNumber { get; set; }

        public bool PrintInvoice { get; set; }

        public bool PrintPackingSlipInsteadOfInvoice { get; set; }

        public SalesPersonDt SalesPerson { get; set; }

        public SellPriceTierDt SellPriceTier { get; set; }

        public string SourceId { get; set; }

        public bool StopCredit { get; set; }

        public bool Taxable { get; set; }

        public SalesTaxDt SalesTax { get; set; }

        public string TollFreeNumber { get; set; }

        public string Website { get; set; }

        public List<ContactDt> Contacts { get; set; }

        public AccountDt CostOfGoodsAccountDt { get; set; }

        public AccountDt SalesAccountDt { get; set; }

        public Guid CustomerId { get; set; }
    }
}
