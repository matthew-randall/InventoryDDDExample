using System;
using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.CommandDomain.Interface
{
    internal interface ICustomer
    {
        Guid CustomerId { get; }
        string CustomerCode { get; }
        string Name { get; }
        bool PrintInvoice { get; }
        bool PrintPackingSlip { get; }
        decimal TaxRate { get; }
        DeliveryMethodDt DeliveryMethod { get; }
        decimal DiscountRate { get; }
        string Email { get; }
        string EmailCc { get; }
        AddressDt PhysicalAddressDt { get; }
        AddressDt PostalAddressDt { get; }
        List<AddressDt> Addresses { get; }
        WarehouseDt Warehouse { get; }
        SalesTaxDt SalesTax { get; }
        CurrencyDt Currency { get; }
        PaymentTermDt PaymentTerm { get; }
        ICompany Company { get; }
    }
}
