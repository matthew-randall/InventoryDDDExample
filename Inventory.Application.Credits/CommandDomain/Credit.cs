using System;
using System.Collections.Generic;
using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Application.Credits.Contracts.Commands;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain
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

        public CreditViewCommand GetCreditViewModel()
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
