using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.QueryDomain.Interfaces
{
    internal interface ICreditViewBuilder
    {
        IEnumerable<ICreditView> Get(IEnumerable<CreditViewDt> creditViewDts);
    }
}
