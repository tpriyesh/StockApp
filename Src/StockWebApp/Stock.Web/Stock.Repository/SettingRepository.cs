using Stock.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Repository
{
    public class SettingRepository :DefaultDisposable, ISettingRepository
    {
       
        /// <summary>
        /// Get all stocks from db
        /// </summary>
        /// <returns></returns>
        public IEnumerable<stock> GetAllStocks()
        {
            return _context.stocks.ToList();
        }

       
    }
}
