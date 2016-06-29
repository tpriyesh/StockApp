using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stock.Web.ViewModels;
using Stock.Dal;
using Stock.Repository;

namespace Stock.Web.Controllers
{
    [Authorize]
    public class PersonalizedStocksController : Controller
    {

        private readonly IPersonalizedStockRepository _personalizedRepo = null;
        private readonly ISettingRepository _settingRep = null;

        public PersonalizedStocksController(IPersonalizedStockRepository personalRep, ISettingRepository settingRep)
        {
            _personalizedRepo = personalRep;
            _settingRep = settingRep;
        }

        /// <summary>
        /// shows all user stocks 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            PersonalizedViewModel vm = new PersonalizedViewModel();
            var userName = User.Identity.Name;
            var user = _personalizedRepo.GetUser(userName);
            var userStocks = _personalizedRepo.GetStocksOfUser(user).Select(x => x.stockcode).ToList();

            vm.stockSymbols = userStocks;
            return View(vm);
        }

        /// <summary>
        /// Json method to fetch user stocks via ajax call
        /// </summary>
        /// <returns></returns>
        public JsonResult GetUserStocks()
        {
            var userName = User.Identity.Name;
            var user = _personalizedRepo.GetUser(userName);
            var userStocks = _personalizedRepo.GetStocksOfUser(user).Select(x => x.stockcode).ToList();
            return Json(userStocks, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Searches stocks based on the term passed in param
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public JsonResult GetStockSymbols(string term)
        {
            var userName = User.Identity.Name;
            var user = _personalizedRepo.GetUser(userName);
            var userStocks = _personalizedRepo.GetStocksOfUser(user).Select(x => x.stockcode).ToList();
            var getAllStocks = _settingRep.GetAllStocks().Select(x => x.stockcode).ToList();
            var stockList = getAllStocks.Except(userStocks).Where(x => x.Contains(term)).ToList();

            return Json(stockList, JsonRequestBehavior.AllowGet);

        }

        /// <summary>
        /// save stock code(term) to user's collection
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult SaveSymbolToUser(string term)
        {
            var userName = User.Identity.Name;
            var user = _personalizedRepo.GetUser(userName);
            _personalizedRepo.SaveStocksToUser(user, term);
            var obj = new
            {
                success = true
            };
            return Json(obj);
        }

        /// <summary>
        /// delete stock code(term) from user collection
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteStockFromUser(string term)
        {
            var userName = User.Identity.Name;
            var user = _personalizedRepo.GetUser(userName);
            _personalizedRepo.DeleteStockFromUser(user, term);
            var obj = new
            {
                success = true
            };
            return Json(obj);

        }

    }
}
