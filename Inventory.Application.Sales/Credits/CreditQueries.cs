using System.Collections.Generic;
using System.Linq;
using Inventory.Application.Sales.Credits.QueryDomain;
using Inventory.Application.Sales.Credits.QueryDomain.Interfaces;
using Inventory.DependencyInjector;
using Inventory.Repository.Sales.Contracts.Interface;
using Inventory.UI.Sales.Contracts;
using Inventory.UI.Sales.Contracts.Credits.Queries;
using Ninject;

namespace Inventory.Application.Sales.Credits
{
    public class CreditQueries : IGetCreditViewList
    {
        public CreditQueries()
        {
            NinjectDependencyInjector.Instance.InjectPropertiesOn(this);
        }

        [Inject]
        public ICreditRetriever CreditRetriever { get; set; }

        public List<CreditViewQuery> Get(int pageSize)
        {
            var queryResults = CreditRetriever.GetCreditsView(pageSize);
            var creditViews = InstantiateCreditViewBuilder().Get(queryResults);
            return creditViews.Select(x => x.GetCreditViewQuery()).ToList();
        }

        internal virtual ICreditViewBuilder InstantiateCreditViewBuilder()
        {
            return new CreditViewBuilder();
        }
    }
}
