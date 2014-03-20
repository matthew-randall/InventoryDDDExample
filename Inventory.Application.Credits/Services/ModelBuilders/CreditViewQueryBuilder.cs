using Inventory.Application.Credits.Contracts.Queries;
using Inventory.Application.Credits.QueryDomain.Interfaces;
using Inventory.Application.Credits.Services.ModelBuilders.Interfaces;

namespace Inventory.Application.Credits.Services.ModelBuilders
{
    internal class CreditViewQueryModelBuilder : ICreditViewQueryModelBuilder
    {
        public CreditViewQuery Build(ICreditView creditView)
        {
            var query = new CreditViewQuery
            {
                CreditNumber = creditView.CreditNumber,
                CustomerCode = creditView.CustomerCode,
                InvoiceNumber = creditView.InvoiceNumber,
                CreditDate = creditView.CreditDate.ToShortDateString(),
                CustomerName = creditView.CustomerName,
                Status = creditView.CreditStatus.ToString(),
                Total = creditView.Total
            };

            return query;
        }
    }
}
