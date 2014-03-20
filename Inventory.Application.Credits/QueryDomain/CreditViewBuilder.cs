using System.Collections.Generic;
using Inventory.Application.Credits.QueryDomain.Interfaces;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.QueryDomain
{
    internal class CreditViewBuilder : ICreditViewBuilder
    {
        public IEnumerable<ICreditView> Get(IEnumerable<CreditViewDt> creditViewDts)
        {
            var creditViews = new List<ICreditView>();

            foreach (var creditViewDt in creditViewDts)
                creditViews.Add(CreateCreditView(creditViewDt));

            return creditViews;
        }

        private ICreditView CreateCreditView(CreditViewDt creditViewDt)
        {
            var creditView = InstantiateCreditView(creditViewDt);

            foreach (var creditViewLineDt in creditViewDt.CreditViewLines)
                CreateAndInitialiseLine(creditViewLineDt, creditView);

            return creditView;
        }

        private void CreateAndInitialiseLine(CreditViewLineDt creditViewLineDt, ICreditInitialiser creditView)
        {
            var line = InstantiateCreditLineView(creditViewLineDt);
            creditView.InitialiseLine(line);
            line.Initialise(creditView);
        }

        internal virtual ICreditInitialiser InstantiateCreditView(CreditViewDt creditViewDt)
        {
            return new CreditView(creditViewDt);
        }

        internal virtual ICreditLineInitialiser InstantiateCreditLineView(CreditViewLineDt creditViewLineDt)
        {
            return new CreditLineView(creditViewLineDt);
        }
            
    }
}
