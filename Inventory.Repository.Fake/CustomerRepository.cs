using System;
using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.Repository.Fake
{
    public class CustomerRepository : ICustomerRetriever
    {
        public CustomerDt GetCustomer(string customerCode)
        {
            return new CustomerDt
            {
                CustomerId = new Guid(),
                BankAccount = "BankAccount",
                BankBranch = "BankBranch",
                BankName = "BankName",
                CustomerCode = "CustomerCode",
                CustomerName = "CustomerName",
                CustomerType = CustomerType.Default,
                DDINumber = "DDINumber",
                DefaultInvoiceEmail = "defaultInvoice@email.com",
                DefaultPackingSlipEmail = "defaultPackingSlip@email.com",
                DiscountRate = 0m,
                Email = "customer@email.com",
                EmailCC = "customerCC@email.com",
                FaxNumber = "FaxNumber",
                GSTVATNumber = "GSTVATNumber",
                InvoiceLayoutId = 1,
                PackingSlipLayoutId = 2,
                MobileNumber = "MobileNumber",
                Notes = "Notes",
                PhoneNumber = "PhoneNumber",
                SourceId = "SourceId",
                PrintPackingSlipInsteadOfInvoice = true,
                TollFreeNumber = "TollFreeNumber",
                Website = "www.customer.web.si",
                Contacts = new List<ContactDt>(),
                CostOfGoodsAccountDt = new AccountDt(),
                SalesAccountDt = new AccountDt(),
                SalesTax = new SalesTaxDt(),
                SalesPerson = new SalesPersonDt(),
                SellPriceTier = new SellPriceTierDt(),
                DefaultPaymentTerm = new PaymentTermDt(),
                DefaultWarehouse = new WarehouseDt(),
                Currency = new CurrencyDt(),
                StopCredit = false,
                Taxable = true,
                PrintInvoice = true,
                Obsolete = false,
            };
        }
    }
}
