using System;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Application.Credits.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain
{
    internal class SalesInvoiceLine : ISalesInvoiceLine
    {
        private readonly SalesInvoiceLineDt _salesInvoiceLine;

        public SalesInvoiceLine(SalesInvoiceLineDt salesInvoiceLine)
        {
            _salesInvoiceLine = salesInvoiceLine;
        }
        
        public Guid SalesInvoiceLineId
        {
            get { return _salesInvoiceLine.SalesInvoiceLineId; }
        }

        public decimal InvoiceQuantity
        {
            get { return _salesInvoiceLine.InvoiceQuantity; }
        }

        public decimal UnitPrice
        {
            get { return _salesInvoiceLine.UnitPrice; }
        }

        public string Notes
        {
            get { return _salesInvoiceLine.Notes; }
        }

        public ProductDt Product
        {
            get { return _salesInvoiceLine.ProductDt; }
        }

        public decimal DiscountedUnitPrice
        {
            get { throw new NotImplementedException(); }
        }

        public ISalesInvoice SalesInvoice
        {
            get { throw new NotImplementedException(); }
        }

        public SalesInvoiceLineViewModel GetSalesInvoiceLineViewModel()
        {
            throw new NotImplementedException();
        }
    }
}
