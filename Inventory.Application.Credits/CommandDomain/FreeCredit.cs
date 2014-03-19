using System;
using System.Collections.Generic;
using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Application.Credits.Contracts.Commands;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain
{
    internal class FreeCredit : BaseCredit, ICredit, IFreeCreditNote
    {
        public FreeCredit(CreditDt creditNote)
            : base(creditNote)
        {
        }

        public ICustomer Customer
        {
            get { throw new NotImplementedException(); }
        }

        public CreditViewCommand GetCreditViewModel()
        {
            throw new NotImplementedException();
        }

        public ICreditLine GetCreditNoteLine(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateCreditLines(IEnumerable<ISalesInvoiceLine> salesInvoiceLine)
        {
            throw new NotImplementedException();
        }
    }
}
