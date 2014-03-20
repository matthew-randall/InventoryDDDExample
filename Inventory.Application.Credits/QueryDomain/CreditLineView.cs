using Inventory.Application.Credits.QueryDomain.Interfaces;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.QueryDomain
{
    internal class CreditLineView : ICreditLineView, ICreditLineInitialiser
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
    }
}
