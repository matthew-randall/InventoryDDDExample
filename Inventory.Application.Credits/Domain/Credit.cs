using System;
using System.Collections.Generic;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Application.Credits.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain
{
    internal class Credit : BaseCredit, ICredit, ICreditNote
    {
        public Credit(CreditDt creditNoteMap)
            : base(creditNoteMap)
        {

        }

        public ISalesInvoice SalesInvoice
        {
            get { throw new NotImplementedException(); }
        }

        public CreditViewModel GetCreditViewModel()
        {
            throw new System.NotImplementedException();
        }

        public ICreditLine GetCreditNoteLine(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateCreditLines(IEnumerable<ISalesInvoiceLine> salesInvoiceLine)
        {
            throw new System.NotImplementedException();
        }
    }
}
