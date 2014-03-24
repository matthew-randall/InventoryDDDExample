using System;
using Inventory.Application.Sales.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Credits.CommandDomain
{
    internal class Customer : ICustomer
    {
        private readonly CustomerDt _customer;
        private readonly ICompany _company;

        public Customer(CustomerDt customer, ICompany company)
        {
            _customer = customer;
            _company = company;
        }

        public CurrencyDt Currency
        {
            get
            {
                return _customer.Currency ?? Company.DefaultCurrency;
            }
        }

        public Guid CustomerId
        {
            get { return _customer.CustomerId; }
        }

        public string CustomerCode
        {
            get { return _customer.CustomerCode; }
        }

        public string CustomerName
        {
            get { return _customer.CustomerName; }
        }

        public string Email
        {
            get { return _customer.Email; }
        }

        public WarehouseDt Warehouse
        {
            get { return _customer.DefaultWarehouse ?? Company.DefaultWarehouse; }
        }

        public ICompany Company 
        {
            get { return _company; }
        }

        public bool Taxable
        {
            get { return _customer.Taxable; }
        }
        
        public SalesTaxDt SalesTax
        {
            get { throw new NotImplementedException(); }
        }

        public int CreateFreeCredit()
        {
            throw new NotImplementedException();
        }
    }
}
