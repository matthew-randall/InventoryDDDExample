using System;
using System.Collections.Generic;
using Inventory.Helpers.Enum;
using Inventory.UI.Sales.Contracts.Credits.Commands;
using Inventory.UI.Sales.Contracts.Credits.Interface;

namespace Inventory.Application.Sales.Credits
{
    public class CreditCommands : ICreditCommands
    {
        public CreditViewCommand GetCreditView(Guid creditId)
        {
            return new CreditViewCommand
            {
                CreditNumber = "CR-000001",
                CustomerCode  = "CUST_01",
                CustomerName  = "John Doe",
                Email  = "john@email.com",
                CustomerCurrency  = CurrencyCode.NZD,
                CreditStatus  = CreditStatus.Parked,
                InvoiceNumber  = "INV-000001",
                InvoiceDate  = DateTime.UtcNow.AddDays(-5),
                DeliveryDate  = DateTime.UtcNow.AddDays(-3),
                CreditDate  = DateTime.UtcNow,
                Reference  = "Customer Reference",
                CreditLines = new List<CreditLineViewCommand>
                {
                    new CreditLineViewCommand
                    {
                        CreditPrice = 12.5m,
                        CreditQuantity = 5,
                        InvoicePrice = 12.5m,
                        InvoiceQuantity = 5,
                        LineNumber = 1,
                        TaxRate = 0.125m,
                        Notes = "These are comments about this line",
                        ProductCode = "PR-00001",
                        ProductDescription = "Description of the product",
                        SubTotal = 62.5m
                    },
                    new CreditLineViewCommand
                    {
                        CreditPrice = 10m,
                        CreditQuantity = 6,
                        InvoicePrice = 10m,
                        InvoiceQuantity = 6,
                        LineNumber = 2,
                        TaxRate = 0.125m,
                        Notes = "",
                        ProductCode = "PR-00002",
                        ProductDescription = "Product description it has",
                        SubTotal = 60m
                    },
                }
            };
        }
    }
}
