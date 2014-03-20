using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Credits.QueryDomain.Interfaces
{
    internal interface ICreditInitialiser : ICreditView
    {
        void InitialiseLine(ICreditLineView creditLineView);
    }
}
