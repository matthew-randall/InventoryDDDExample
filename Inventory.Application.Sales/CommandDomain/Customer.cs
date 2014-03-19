
using System;
using System.Collections.Generic;
using Inventory.Application.Sales.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.CommandDomain
{
    internal class Customer : ICustomer
    {
        private readonly CustomerDt _customer;

        public Customer(CustomerDt customer, ICompany company)
        {
            _customer = customer;
            Company = company;
        }

        public ICompany Company { get; private set; }

        public Guid CustomerId
        {
            get { return _customer.CustomerId; }
        }

        public string CustomerCode { get; private set; }

        public string Name { get; private set; }

        public bool PrintInvoice { get; private set; }

        public bool PrintPackingSlip { get; private set; }

        public decimal TaxRate { get; private set; }

        public DeliveryMethodDt DeliveryMethod { get; private set; }

        public decimal DiscountRate { get; private set; }

        public string Email { get; private set; }

        public string EmailCc { get; private set; }

        public AddressDt PhysicalAddressDt { get; private set; }

        public AddressDt PostalAddressDt { get; private set; }

        public List<AddressDt> Addresses { get; private set; }

        public WarehouseDt Warehouse { get; private set; }

        public SalesTaxDt SalesTax { get; private set; }

        public CurrencyDt Currency { get; private set; }

        public PaymentTermDt PaymentTerm { get; private set; }
    }
}
