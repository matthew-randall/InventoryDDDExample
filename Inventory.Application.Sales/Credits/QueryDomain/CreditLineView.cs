using Inventory.Application.Sales.Credits.QueryDomain.Interfaces;
using Inventory.Helpers.Calculators;
using Inventory.Helpers.Calculators.Interfaces;
using Inventory.Helpers.Structs;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Credits.QueryDomain
{
    internal class CreditLineView : ICreditLineView, ICreditLineInitialiser, ILineCalculable
    {
        private readonly CreditViewLineDt _creditViewLineDt;
        private ICreditView _creditView;

        public CreditLineView(CreditViewLineDt creditViewLineDt)
        {
            _creditViewLineDt = creditViewLineDt;
        }

        public void Initialise(ICreditView creditView)
        {
            _creditView = creditView;
        }

        public ICreditView CreditView
        {
            get { return _creditView; }
        }

        public Monetary Price
        {
            get { return _creditViewLineDt.CreditPrice; }
        }

        public int Quantity
        {
            get { return _creditViewLineDt.CreditQuantity; }
        }

        public decimal TaxRate
        {
            get { return _creditViewLineDt.TaxRate; }
        }

        public Monetary SubTotal
        {
            get { return LineCalculator.SubTotal(this); }
        }

        public Monetary TaxTotal
        {
            get { return LineCalculator.TaxTotal(this); }
        }

        public Monetary Total
        {
            get { return LineCalculator.Total(this); }
        }
    }
}
