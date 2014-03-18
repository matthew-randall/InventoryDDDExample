using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Sales.Contracts.Models
{
    public class SalesTaxVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
        public string TaxType { get; set; }
    }
}
