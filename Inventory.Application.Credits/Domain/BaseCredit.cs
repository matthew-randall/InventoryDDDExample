﻿using System;
using System.Collections.Generic;
using System.Linq;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Application.Credits.Domain.Interface;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain
{
    internal abstract class BaseCredit
    {
        protected readonly CreditDt CreditDt;

        protected BaseCredit(CreditDt creditDt)
        {
            CreditDt = creditDt;
        }

        public Guid CreditId
        {
            get { return CreditDt.CreditId; }
        }
        
        public string CreditNumber
        {
            get { return CreditDt.CreditNumber; }
        }

        public decimal SubTotal
        {
            get { throw new NotImplementedException(); }
            //get { return CreditLines.Sum(x => x.SubTotal); }
        }

        public decimal TaxTotal
        {
            get { throw new NotImplementedException(); }
            //get { return CreditLines.Sum(x => x.LineTax); }
        }

        public decimal Total
        {
            get { throw new NotImplementedException(); }
            //get { return CreditLines.Sum(x => x.Total); }
        }

        public DateTime CreditDate
        {
            get { return CreditDt.CreditDate; }
        }

        public string Notes
        {
            get { return CreditDt.Notes; }
        }

        public CreditStatus CreditStatus
        {
            get { return CreditDt.Status; }
        }

        public CreditType CreditType
        {
            get { return CreditDt.CreditType; }
        }
        
        public virtual List<ICreditLine> CreditLines
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<CreditLineViewModel> CreditLinesView()
        {
            throw new NotImplementedException();
        }
    }
}
