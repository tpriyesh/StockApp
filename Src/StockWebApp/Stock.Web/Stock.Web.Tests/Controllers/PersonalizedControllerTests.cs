using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock.Web.Tests.MockFrameworkObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Stock.Web.Controllers;
using System.Web.Mvc;
using System.Web.Routing;
using Stock.Web.ViewModels;
using System.Web.Script.Serialization;

namespace Stock.Web.Tests.Controllers
{
    [TestClass]
 public class PersonalizedControllerTests
    {
        [TestInitialize]
        public void Setup()
        {
            HttpContext.Current = MockHelperFactory.FakeHttpContext();
        }

        [TestMethod]
        public void Can_return_user_personalized_stocks() {

            var httpContext = GetHttpContext(true, 2);
           var personalStockController= GetPersonalStockControllerInstance(httpContext);
           personalStockController.ControllerContext = new ControllerContext { HttpContext = httpContext };
           var result = (ViewResult)personalStockController.Index();
           var model = result.ViewData.Model as PersonalizedViewModel;
           Assert.IsNotNull(model);
           Assert.AreEqual(1, model.stockSymbols.Count);
        }
        [TestMethod]
        public void get_stock_sybmol_based_on_term(){

            var httpContext = GetHttpContext(true, 2);
            var personalStockController = GetPersonalStockControllerInstance(httpContext);
            personalStockController.ControllerContext = new ControllerContext { HttpContext = httpContext };
            var result = (JsonResult)personalStockController.GetStockSymbols("go");
        var result1 = (JsonResult)personalStockController.GetStockSymbols("msft");

            List<string> model = result.Data as List<string>;
            List<string> model1 = result1.Data as List<string>;

            Assert.AreEqual(0, model.Count);
            Assert.AreEqual(1, model1.Count);

        }

        [TestMethod]
        public void save_stock_user_method_test()
        {

            var httpContext = GetHttpContext(true, 2);
            var personalStockController = GetPersonalStockControllerInstance(httpContext);
            personalStockController.ControllerContext = new ControllerContext { HttpContext = httpContext };
            var result = (JsonResult)personalStockController.SaveSymbolToUser("go");
            dynamic model = result.Data;
            Assert.AreEqual(true, model.success);
        }

        [TestMethod]
        public void delete_stock_user_method_test()
        {

            var httpContext = GetHttpContext(true, 2);
            var personalStockController = GetPersonalStockControllerInstance(httpContext);
            personalStockController.ControllerContext = new ControllerContext { HttpContext = httpContext };
            var result = (JsonResult)personalStockController.DeleteStockFromUser("go");
            dynamic model = result.Data;
            Assert.AreEqual(true, model.success);
        }

      



        private static HttpContextBase GetHttpContext(bool isAuthenticated, int userId)
        {
            var mockContext = MockFactory.GetMockContext(userId, isAuthenticated);
            return mockContext;
        }

        private static PersonalizedStocksController GetPersonalStockControllerInstance(HttpContextBase httpContext)
        {
            var settingRepository = MockObjectFactory.CreateSettingRepository();
            var personalizedRepository = MockObjectFactory.CreatePersonalizedRepository();
            var personalizedController = new PersonalizedStocksController(personalizedRepository, settingRepository)
                            {
                    Url = new UrlHelper(httpContext.Request.RequestContext, RouteTable.Routes)
                };
            return personalizedController;
        }

    }
}
