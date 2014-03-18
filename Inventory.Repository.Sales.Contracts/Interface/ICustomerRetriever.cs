using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Sales.Contracts.Interface
{
    public interface ICustomerRetriever
    {
        CustomerDt GetCustomer(string customerCode);
    }
}
