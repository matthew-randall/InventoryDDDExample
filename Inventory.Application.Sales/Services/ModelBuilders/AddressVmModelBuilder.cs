﻿using Inventory.Application.Sales.Contracts.Models;
using Inventory.Application.Sales.Services.ModelBuilders.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Services.ModelBuilders
{
    internal class AddressVmModelBuilder : IAddressVmModelBuilder
    {
        public AddressVm Build(AddressDt addressDt)
        {
            var addressVm = new AddressVm();

            addressVm.City = addressDt.City;
            addressVm.Country = addressDt.Country;
            addressVm.Name = addressDt.Name;
            addressVm.PostCode = addressDt.PostCode;
            addressVm.Region = addressDt.Region;
            addressVm.StreetAddress = addressDt.StreetAddress;
            addressVm.Suburb = addressDt.Suburb;

            return addressVm;
        }
    }
}
