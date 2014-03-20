using System.Collections.Generic;
using System.Linq;
using Inventory.Application.Credits.Contracts.Interface;
using Inventory.Application.Credits.Contracts.Queries;
using Inventory.Application.Credits.QueryDomain;
using Inventory.Application.Credits.QueryDomain.Interfaces;
using Inventory.DependencyInjector;
using Inventory.Repository.Credits.Contracts.Interfaces;
using Ninject;

namespace Inventory.Application.Credits
{
    public class CreditQueries : ICreditQueries
    {
        public CreditQueries()
        {
            NinjectDependencyInjector.Instance.InjectPropertiesOn(this);
        }

        [Inject]
        public ICreditRetriever CreditRetriever { get; set; }

        public List<CreditViewQuery> GetCreditViewList(int pageSize)
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
