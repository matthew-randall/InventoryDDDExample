using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Credits.QueryDomain.Interfaces
{
    internal interface ICreditViewBuilder
    {
        IEnumerable<ICreditView> Get(IEnumerable<CreditViewDt> creditViewDts);
    }
}
