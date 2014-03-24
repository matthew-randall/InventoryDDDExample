using System.Collections.Generic;
using Inventory.Application.Sales.Credits;
using Inventory.Application.Sales.Credits.QueryDomain.Interfaces;
using Inventory.DependencyInjector;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;
using Inventory.UI.Sales.Contracts.Credits.Queries;
using Moq;
using Ninject;
using NUnit.Framework;

namespace Inventory.Application.Sales.Tests.Unit.Credits
{
    [TestFixture]
    public class CreditQueriesTests
    {
        private Mock<ICreditRetriever> _mockedCreditRetriever;
        private CreditQueries _creditQueries;
        private List<CreditViewDt> _creditViewDts;
        private Mock<ICreditViewBuilder> _mockedCreditViewBuilder;
        private Mock<CreditQueries> _mockedCreditQueries;
        private List<ICreditView> _creditViews;
        private Mock<ICreditView> _creditView1;
        private Mock<ICreditView> _creditView2;
        private Mock<ICreditView> _creditView3;

        [SetUp]
        public void SetUp()
        {
            _creditViewDts = new List<CreditViewDt>();

            _creditView1 = new Mock<ICreditView>();
            _creditView2 = new Mock<ICreditView>();
            _creditView3 = new Mock<ICreditView>();

            _creditViews = new List<ICreditView>
            {
                _creditView1.Object,
                _creditView2.Object,
                _creditView3.Object,
            };

            _mockedCreditViewBuilder = new Mock<ICreditViewBuilder>();
            _mockedCreditViewBuilder.Setup(x => x.Get(_creditViewDts)).Returns(_creditViews);

            _mockedCreditRetriever = new Mock<ICreditRetriever>();
            _mockedCreditRetriever.Setup(x => x.GetCreditsView(It.IsAny<int>())).Returns(_creditViewDts);




            IKernel kernal = new StandardKernel();
            kernal.Bind<ICreditRetriever>().ToConstant(_mockedCreditRetriever.Object);
            NinjectDependencyInjector.Instance.Initialize(kernal);

            _mockedCreditQueries = new Mock<CreditQueries>();
            _mockedCreditQueries.Setup(x => x.InstantiateCreditViewBuilder()).Returns(_mockedCreditViewBuilder.Object);
            _creditQueries = _mockedCreditQueries.Object;

        }

        [Test]
        public void GetCreditViewList_Test01_QueryDatabase()
        {
            _creditQueries.GetCreditViewList(10);
            _mockedCreditRetriever.Verify(x => x.GetCreditsView(10), Times.Once);
        }

        [Test]
        public void GetCreditViewList_Test02_BuildDomain()
        {
            _creditQueries.GetCreditViewList(10);
            _mockedCreditViewBuilder.Verify(x => x.Get(_creditViewDts), Times.Once);
        }

        [Test]
        public void GetCreditViewList_Test03_GetQueryView()
        {
            var creditViewQuery1 = new CreditViewQuery();
            var creditViewQuery2 = new CreditViewQuery();
            var creditViewQuery3 = new CreditViewQuery();

            _creditView1.Setup(x => x.GetCreditViewQuery()).Returns(creditViewQuery1);
            _creditView2.Setup(x => x.GetCreditViewQuery()).Returns(creditViewQuery2);
            _creditView3.Setup(x => x.GetCreditViewQuery()).Returns(creditViewQuery3);

            var results = _creditQueries.GetCreditViewList(10);

            Assert.That(results[0] == creditViewQuery1);
            Assert.That(results[1] == creditViewQuery2);
            Assert.That(results[2] == creditViewQuery3);
        }
    }
}
