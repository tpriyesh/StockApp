using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Dal;


namespace Stock.Repository
{
    public class PersonalizedRepository :DefaultDisposable, IPersonalizedStockRepository
    {
      
        /// <summary>
        /// save stock to db
        /// </summary>
        /// <param name="userObj"></param>
        /// <param name="stockCode"></param>
        public void SaveStocksToUser(user userObj, string stockCode)
        {
            userstock stock = new userstock();
            stock.user = userObj;
            stock.stockcode = stockCode;
            _context.userstocks.InsertOnSubmit(stock);
            _context.SubmitChanges();
        }
        /// <summary>
        /// get user stock from db
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public IEnumerable<userstock> GetStocksOfUser(user userObj)
        {
            return _context.userstocks.Where(x => x.user_id == userObj.id).ToList();
        }

        /// <summary>
        /// Get user from db
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public user GetUser(string userName)
        {
            return _context.users.Where(x => x.username == userName).FirstOrDefault();
        }

        /// <summary>
        /// delete stock from user
        /// </summary>
        /// <param name="userObj"></param>
        /// <param name="stockCode"></param>
        public void DeleteStockFromUser(user userObj, string stockCode)
        {
            var stock = _context.userstocks.Where(x => x.user_id == userObj.id && x.stockcode == stockCode).FirstOrDefault();
            _context.userstocks.DeleteOnSubmit(stock);
            _context.SubmitChanges();
        }

       
    }
}
