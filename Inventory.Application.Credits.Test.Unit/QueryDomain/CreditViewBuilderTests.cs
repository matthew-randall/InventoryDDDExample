using System.Collections.Generic;
using System.Linq;
using Inventory.Application.Credits.QueryDomain;
using Inventory.Application.Credits.QueryDomain.Interfaces;
using Inventory.Repository.Base.Contracts.Models;
using Moq;
using NUnit.Framework;

namespace Inventory.Application.Credits.Tests.Unit.QueryDomain
{
    [TestFixture]
    public class CreditViewBuilderTests
    {
        private CreditViewBuilder _creditViewBuilder;
        private List<CreditViewDt> _creditViewDts;
        private Mock<CreditViewBuilder> _mockedCreditViewBuilder;
        private Mock<ICreditInitialiser> _mockedCreditView2;
        private Mock<ICreditInitialiser> _mockedCreditView1;
        private Mock<ICreditLineInitialiser> _mockedCreditLineView1;
        private Mock<ICreditLineInitialiser> _mockedCreditLineView2;
        private Mock<ICreditLineInitialiser> _mockedCreditLineView3;

        [SetUp]
        public void SetUp()
        {
            _creditViewDts = new List<CreditViewDt>
            {
                new CreditViewDt
                {
                    CreditViewLines = new List<CreditViewLineDt>
                    {
                        new CreditViewLineDt(),
                        new CreditViewLineDt(),
                    },
                },
                new CreditViewDt
                {
                    CreditViewLines = new List<CreditViewLineDt>
                    {
                        new CreditViewLineDt()
                    }
                }
            };

            _mockedCreditView1 = new Mock<ICreditInitialiser>();
            _mockedCreditView2 = new Mock<ICreditInitialiser>();

            _mockedCreditLineView1 = new Mock<ICreditLineInitialiser>();
            _mockedCreditLineView2 = new Mock<ICreditLineInitialiser>();
            _mockedCreditLineView3 = new Mock<ICreditLineInitialiser>();

            _mockedCreditViewBuilder = new Mock<CreditViewBuilder>();
            
            _mockedCreditViewBuilder.Setup(x => x.InstantiateCreditView(_creditViewDts[0]))
                .Returns(_mockedCreditView1.Object);

            _mockedCreditViewBuilder.Setup(x => x.InstantiateCreditView(_creditViewDts[1]))
                .Returns(_mockedCreditView2.Object);
            
            _mockedCreditViewBuilder.Setup(x => x.InstantiateCreditLineView(_creditViewDts[0].CreditViewLines[0]))
                .Returns(_mockedCreditLineView1.Object);

            _mockedCreditViewBuilder.Setup(x => x.InstantiateCreditLineView(_creditViewDts[0].CreditViewLines[1]))
                .Returns(_mockedCreditLineView2.Object);

            _mockedCreditViewBuilder.Setup(x => x.InstantiateCreditLineView(_creditViewDts[1].CreditViewLines[0]))
                .Returns(_mockedCreditLineView3.Object);

            _creditViewBuilder = _mockedCreditViewBuilder.Object;
        }

        [Test]
        public void Get_Test01_InstantiateEachCreditView()
        {
            _creditViewBuilder.Get(_creditViewDts);

            _mockedCreditViewBuilder.Verify(x => x.InstantiateCreditView(_creditViewDts[0]), Times.Once);
            _mockedCreditViewBuilder.Verify(x => x.InstantiateCreditView(_creditViewDts[1]), Times.Once);
        }

        [Test]
        public void Get_Test02_InstantiateEachCreditLineView()
        {
            _creditViewBuilder.Get(_creditViewDts);

            _mockedCreditViewBuilder.Verify(x => x.InstantiateCreditLineView(_creditViewDts[0].CreditViewLines[0]), Times.Once);
            _mockedCreditViewBuilder.Verify(x => x.InstantiateCreditLineView(_creditViewDts[0].CreditViewLines[1]), Times.Once);
            _mockedCreditViewBuilder.Verify(x => x.InstantiateCreditLineView(_creditViewDts[1].CreditViewLines[0]), Times.Once);
        }

        [Test]
        public void Get_Test03_AssignCorrectLinesToViews()
        {
            _creditViewBuilder.Get(_creditViewDts);

            _mockedCreditView1.Verify(x => x.InitialiseLine(_mockedCreditLineView1.Object), Times.Once);
            _mockedCreditView1.Verify(x => x.InitialiseLine(_mockedCreditLineView2.Object), Times.Once);

            _mockedCreditView2.Verify(x => x.InitialiseLine(_mockedCreditLineView3.Object), Times.Once);
        }

        [Test]
        public void Get_Test04_AssignCorrectViewsToLines()
        {
            _creditViewBuilder.Get(_creditViewDts);

            _mockedCreditLineView1.Verify(x => x.Initialise(_mockedCreditView1.Object), Times.Once);
            _mockedCreditLineView2.Verify(x => x.Initialise(_mockedCreditView1.Object), Times.Once);
            _mockedCreditLineView3.Verify(x => x.Initialise(_mockedCreditView2.Object), Times.Once);
        }

        [Test]
        public void Get_Test05_CreditViews()
        {
            var results = _creditViewBuilder.Get(_creditViewDts).ToList();

            Assert.That(results[0] == _mockedCreditView1.Object);
            Assert.That(results[1] == _mockedCreditView2.Object);
        }
    }
}
