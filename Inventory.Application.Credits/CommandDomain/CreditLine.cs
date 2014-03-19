using System;
using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Application.Credits.Contracts.Commands;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain
{
    internal class CreditLine : BaseCreditLine, ICreditLine, ICreditNoteLine
    {
        public CreditLine(ICredit credit, CreditLineDt creditLine)
            : base( credit, creditLine)
        {
            
        }

        public CreditLineViewCommand GetCreditLineViewModel()
        {
            throw new NotImplementedException();
        }

        public void Update(CreditLineViewCommand creditLineView)
        {
            throw new NotImplementedException();
        }

        public virtual ISalesInvoiceLine SalesInvoiceLine
        {
            get { throw new NotImplementedException(); }
        }
    }
}
