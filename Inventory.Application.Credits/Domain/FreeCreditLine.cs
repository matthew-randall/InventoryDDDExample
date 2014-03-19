using System;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Application.Credits.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain
{
    internal class FreeCreditLine : BaseCreditLine, ICreditLine, IFreeCreditLine
    {
        public FreeCreditLine(ICredit creditWorkflow, CreditLineDt creditLine)
            : base( creditWorkflow, creditLine)
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
    }
}
