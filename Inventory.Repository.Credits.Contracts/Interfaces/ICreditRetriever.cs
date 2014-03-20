using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Credits.Contracts.Interfaces
{
    public interface ICreditRetriever
    {
        IEnumerable<CreditViewDt> GetCreditsView(int pageSize);
    }
}
