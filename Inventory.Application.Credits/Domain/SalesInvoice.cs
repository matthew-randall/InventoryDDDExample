﻿using System;
using System.Collections.Generic;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Application.Credits.Domain.Interface;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain
{
    internal class SalesInvoice : ISalesInvoice
    {
        private readonly SalesInvoiceDt _salesInvoice;

        public SalesInvoice(SalesInvoiceDt salesInvoice)
        {
            _salesInvoice = salesInvoice;
        }

        public Guid SalesInvoiceId
        {
            get { return _salesInvoice.SalesInvoiceId; }
        }

        public string Notes
        {
            get { return _salesInvoice.Notes; }
        }

        public decimal TaxRate
        {
            get { return _salesInvoice.TaxRate; }
        }

        public DateTime InvoiceDate
        {
            get { return _salesInvoice.InvoiceDate; }
        }

        public string CustomerRef
        {
            get { return _salesInvoice.CustomerRef; }
        }

        public DateTime RequiredDate
        {
            get { return _salesInvoice.RequiredDate.Value; }
        }

        public string InvoiceNumber
        {
            get { return _salesInvoice.InvoiceNumber; }
        }

        public SalesInvoiceStatus InvoiceStatus
        {
            get { return _salesInvoice.InvoiceStatus; }
        }

        public IEnumerable<ISalesInvoiceLine> SalesInvoiceLines
        {
            get { throw new NotImplementedException(); }
        }

        public ICustomer Customer
        {
            get { throw new NotImplementedException(); }
        }

        public SalesInvoiceViewModel GetSalesInvoiceViewModel()
        {
            throw new NotImplementedException();
        }

        public Guid CreateNewCredit()
        {
            throw new NotImplementedException();
        }
    }
}
