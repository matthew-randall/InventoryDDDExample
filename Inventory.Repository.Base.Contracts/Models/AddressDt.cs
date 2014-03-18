using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Base.Contracts.Models
{
    public class AddressDt
    {
        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string PostCode { get; set; }
    }
}
