using System;
using System.Collections.Generic;
using Inventory.Helpers.Enum;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.Repository.Fake
{
    public class CreditsRepository : ICreditRetriever
    {
        public IEnumerable<CreditViewDt> GetCreditsView(int pageSize)
        {
            return new List<CreditViewDt>
            {
                new CreditViewDt
                {
                    CreditDate = DateTime.UtcNow.AddDays(-100),
                    CreditId = Guid.NewGuid(),
                    CreditNumber = "CR-0001",
                    CustomerCode = "CUST-001",
                    CustomerName = "John Doe",
                    InvoiceNumber = "INV-002",
                    Status = CreditStatus.Parked,
                    CreditViewLines = new List<CreditViewLineDt>()
                    {
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 123.4356m,
                            CreditQuantity = 20,
                            TaxRate = 0.125m
                        },
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 12.356m,
                            CreditQuantity = 10,
                            TaxRate = 0.10m
                        },
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 9.9999m,
                            CreditQuantity = 6,
                            TaxRate = 0.18125m
                        }
                    }
                },
                new CreditViewDt
                {
                    CreditDate = DateTime.UtcNow.AddDays(-10),
                    CreditId = Guid.NewGuid(),
                    CreditNumber = "CR-0002",
                    CustomerCode = "CUST-004",
                    CustomerName = "James Doltan",
                    InvoiceNumber = "INV-008",
                    Status = CreditStatus.Parked,
                    CreditViewLines = new List<CreditViewLineDt>
                    {
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 18.46m,
                            CreditQuantity = 10,
                            TaxRate = 0.10m
                        },
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 12.56m,
                            CreditQuantity = 1,
                            TaxRate = 0.10m
                        },
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 1.125m,
                            CreditQuantity = 8,
                            TaxRate = 0.185m
                        },
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 5.125m,
                            CreditQuantity = 9,
                            TaxRate = 0.225m
                        }
                    }
                },
                new CreditViewDt
                {
                    CreditDate = DateTime.UtcNow.AddDays(-10),
                    CreditId = Guid.NewGuid(),
                    CreditNumber = "CR-0004",
                    CustomerCode = "CUST-012",
                    CustomerName = "John McClaine",
                    InvoiceNumber = "INV-018",
                    Status = CreditStatus.Parked,
                    CreditViewLines = new List<CreditViewLineDt>
                    {
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 1.6m,
                            CreditQuantity = 1,
                            TaxRate = 0.15m
                        },
                        new CreditViewLineDt
                        {
                            CreditLineId = Guid.NewGuid(),
                            CreditPrice = 1.56m,
                            CreditQuantity = 13,
                            TaxRate = 0.12m
                        },
                    }
                },

            };
        }
    }
}
