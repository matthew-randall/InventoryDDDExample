using System;
using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain
{
    internal abstract class BaseCreditLine
    {
        protected readonly ICredit Credit;
        protected readonly CreditLineDt CreditLineDt;

        protected BaseCreditLine(ICredit credit, CreditLineDt creditLine)
        {
            Credit = credit;
            CreditLineDt = creditLine;
        }

        public Guid CreditLineId
        {
            get { return CreditLineDt.CreditLineId; }
        }

        public decimal CreditPrice
        {
            get { return CreditLineDt.CreditPrice; }
        }

        public decimal CreditQuantity
        {
            get { return CreditLineDt.CreditQuantity; }
        }

        public decimal SubTotal
        {
            get { return CreditPrice*CreditQuantity; }
        }

        public decimal TaxRate
        {
            get { return CreditLineDt.TaxRate; }
        }

        public decimal LineTax
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal Total
        {
            get { return SubTotal + LineTax; }
        }
        
        public int LineNumber
        {
            get { return CreditLineDt.LineNumber; }
        }

        public bool ReturnToStock
        {
            get { return CreditLineDt.ReturnToStock; }
        }

        public string Notes
        {
            get { return CreditLineDt.Notes; }
        }

        public Guid CreditReasonId
        {
            get { return CreditLineDt.CreditReasonDtId; }
        }
    }
}
