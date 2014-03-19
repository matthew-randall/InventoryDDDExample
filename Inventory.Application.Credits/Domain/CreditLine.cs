using System;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Application.Credits.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain
{
    internal class CreditLine : BaseCreditLine, ICreditLine, ICreditNoteLine
    {
        public CreditLine(ICredit credit, CreditLineDt creditLine)
            : base( credit, creditLine)
        {
            
        }

        public CreditLineViewModel GetCreditLineViewModel()
        {
            throw new NotImplementedException();
        }

        public void Update(CreditLineViewModel creditLineView)
        {
            throw new NotImplementedException();
        }

        public virtual ISalesInvoiceLine SalesInvoiceLine
        {
            get { throw new NotImplementedException(); }
        }
    }
}
